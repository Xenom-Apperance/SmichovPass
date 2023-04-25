using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace SmichovPass
{
    public partial class App : Form
    {
        private List<record> database;
        private DataTable dataTable;
        public App()
        {
            InitializeComponent();
            this.database = new List<record>(); //Vytvořit list s hesly
            LoadDataTable(); //Nahrát list s hesly do objektu typu DataTable
            PasswordViewer.DataSource = dataTable; //Nahrát dataTable do DataGridView
        }
        private void LoadDataTable()
        {
            this.dataTable = new DataTable(); //Vytvořit nový DataTable (oprava chyb s neaktualizací zobrazovače pole)
            //Vytvořit nové sloupce v DataTable
            dataTable.Columns.Add("Stranka", typeof(string));
            dataTable.Columns.Add("Jmeno", typeof(string));
            dataTable.Columns.Add("Heslo", typeof(string));
            //Nahrát informace z listu do DataTable
            foreach (var record in database)
            {
                DataRow row = dataTable.NewRow();
                row["Stranka"] = record.Stranka;
                row["Jmeno"] = record.Jmeno;
                row["Heslo"] = record.Heslo;
                dataTable.Rows.Add(row);
            }
        }

        private void UpdateListFromDataTable()
        {
            database.Clear(); //Vymazat aktuální, zastaralý list
            //Zjistit úpravy datapole uživatelem a nahrání do listu database
            foreach (DataRow row in dataTable.Rows)
            {
                record r = new record();
                //Přečíst data z dataTable
                r.Stranka = row["Stranka"].ToString();
                r.Jmeno = row["Jmeno"].ToString();
                r.Heslo = row["Heslo"].ToString();
                database.Add(r);
            }
        }


        private void CopyButton_Click(object sender, EventArgs e)
        {
            record r = PasswordViewer.SelectedRows[0].DataBoundItem as record; //Zjistit zvolené heslo
            Clipboard.SetText(r.Heslo); //Vložit heslo do schránky
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            //Vytvořit záznam s parametry zadané uživatelem
            record r = new record { Stranka = StrankaBox.Text, Jmeno = JmenoBox.Text, Heslo = HesloBox.Text };
            database.Add(r); //Přidat záznam do databáze
            LoadDataTable(); //Nahrát nový list do DataTable
            PasswordViewer.DataSource = dataTable; //Aktualizovat datapole
        }

        private void RemoveRecord_Click(object sender, EventArgs e)
        {
            int index = PasswordViewer.SelectedRows[0].Index; //Zjistit zvolený řádek
            database.RemoveAt(index); //Smazat zvolený záznam (heslo)
            LoadDataTable(); //Nahrát aktualizovaný list do DataTable
            PasswordViewer.DataSource = dataTable; //Aktualizovat datapole
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            UpdateListFromDataTable(); //Zjistit a nahrát úpravy dataTable uživatelem do database
            string s = "";
            //Převést databázi na jeden dlouhý řetězec (string)
            foreach (record i in database)
            {
                s = s + i.Stranka + "," + i.Jmeno + "," + i.Heslo + ";";
            }
            //Vytvořit okno o upozornění
            DialogResult dr = MessageBox.Show("Jste si jistí s vaším klíčem? Po zašifrování není možné soubor s hesly bez klíče otevřít!","Klíč", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    return;
            }
            //Zašifrovat data
            s = EncryptAesAndSha(s, KeyBox.Text);

            // Zobrazení okna pro uložení
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Ulozit hesla do souboru";
            saveFileDialog1.ShowDialog();

            // Kontrola, jestli není název prázdný
            if (saveFileDialog1.FileName != "")
            {
                // Uložit do .txt formátu
                System.IO.File.WriteAllText(saveFileDialog1.FileName, s);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            UpdateListFromDataTable(); //Zjistit a nahrát úpravy dataTable uživatelem do database
            //Vytvořit okno o upozornění
            DialogResult dr = MessageBox.Show("Jste si jistí s vaším klíčem? Data aktuálně viditelná v datovém poli nemusí být uložená!", "Klíč", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    return;
            }
            database.Clear(); //Vynulovat databázi
            LoadDataTable();
            // Zobrazení okna pro výběr textového souboru
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Open a Text File";
            openFileDialog1.ShowDialog();

            // Kontrola, jestli není název prázdný
            if (openFileDialog1.FileName != "")
            {
                // Přečíst text ze zvoleného zdroje
                string s = System.IO.File.ReadAllText(openFileDialog1.FileName);
                string[] decryptstring = s.Split(';');
                byte[] ciphertext = Convert.FromBase64String(decryptstring[0].Trim());
                byte[] IV = Convert.FromBase64String(decryptstring[1]);
                byte[] key;
                using (SHA256 sha256 = SHA256.Create())
                {
                    // Převést řetězec na sekvenci bytů
                    byte[] inputBytes = Encoding.UTF8.GetBytes(KeyBox.Text);

                    // Spočítat hash a vytvořit klíč
                    key = sha256.ComputeHash(inputBytes);
                }
                s = Decrypt(ciphertext, key, IV);
                if (s == null)
                {
                    return;
                }
                // Nahrát text do databáze pro zobrazení
                string[] records = s.Split(';');
                foreach (string i in records)
                {
                    string[] info = i.Split(',');
                    //Výjimka, kdy na konci řetězce je null
                    if (info.Length == 1)
                    {
                        break;
                    }
                    database.Add(new record { Stranka = info[0], Jmeno = info[1], Heslo = info[2] });
                }
            }
            LoadDataTable(); //Nahrát list do DataTable
            PasswordViewer.DataSource = dataTable; //Aktualizovat datapole
        }


        //!!!Zde začíná kryptografický kód!!!

        static string EncryptAesAndSha(string raw, string keystring)
        {
            //Zahashovat plaintext klíč na hash, který bude sloužit jako klíč
            byte[] key;
            using (SHA256 sha256 = SHA256.Create())
            {
                // Převést řetězec na sekvenci bytů
                byte[] inputBytes = Encoding.UTF8.GetBytes(keystring);

                // Spočítat hash a vytvořit klíč
                key = sha256.ComputeHash(inputBytes);
            }
            try
            {
                // Vytvořit AES managed
                using (AesManaged aes = new AesManaged())
                {
                    // Zašifrovat řetězec
                    byte[] iv = new byte[16];
                    using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                    {
                        rng.GetBytes(iv);
                    }
                    byte[] encrypted = Encrypt(raw, key, iv);
                    string output = Convert.ToBase64String(encrypted);
                    string initvector = Convert.ToBase64String(iv);
                    return output + ";" + initvector;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return null;
            }
        }
        static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            using (AesManaged aes = new AesManaged())
            {
                // Vytvořit objekt šifrovače
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Vytvořit memorystream
                using (MemoryStream ms = new MemoryStream())
                {
                    // Vytvořit cryptostream, který vrátí svůj výsledek do definovaného memorystreamu
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Vytvořit streamwriter pro zapsání streamu
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data
            return encrypted;
        }
        static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            try
            {
                string plaintext = null;
                // Vytvořit aesmanaged
                using (AesManaged aes = new AesManaged())
                {
                    // Vytvořit dešifrovače
                    ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                    // Vytvořit streamy potřebné k dešifrování
                    using (MemoryStream ms = new MemoryStream(cipherText))
                    {
                        // Vytvořit cryptostream
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            // Přečíst a zapsat cryptostream
                            using (StreamReader reader = new StreamReader(cs))
                                plaintext = reader.ReadToEnd();
                        }
                    }
                }
                return plaintext;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Došlo k chybě při dešifrování: " + ex.Message);
                return null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    public class record
    {
        //Objekt záznamu, obsahuje stránku, jmeno a heslo jako proměnné
        public string Stranka { get; set; }
        public string Jmeno { get; set; }
        public string Heslo { get; set; }
    }
}
