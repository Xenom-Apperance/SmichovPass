using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmichovPass
{
    public partial class Form1 : Form
    {
        private List<record> database;
        public Form1()
        {
            InitializeComponent();
            this.database = new List<record>();
            this.database.Add(new record { Stranka = "google.com", Jmeno = "admin", Heslo = "1234"});
            this.database.Add(new record { Stranka = "ssps.cz", Jmeno = "sablik", Heslo = "4321" });
            PasswordViewer.DataSource = database;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Přečtení řádku zvoleného uživatelem
                var selectedRecord = PasswordViewer.SelectedRows[0].DataBoundItem as record; 
                //Nahrát data ze zvoleného řádku do textových polí
                StrankaBox.Text = selectedRecord.Stranka; 
                JmenoBox.Text = selectedRecord.Jmeno;
                HesloBox.Text = selectedRecord.Heslo;
            }
            catch (Exception ex)
            {
                //V případě chyby
                MessageBox.Show("Chyba: " + ex.Message + "-" + ex.Source);
            }
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            record r = new record { Stranka = "", Jmeno = "", Heslo = "" }; //Vytvořit prázdný záznam
            database.Add(r);
            PasswordViewer.DataSource = null; //Oprava chyby s aktualizací datapole
            PasswordViewer.DataSource = database; //Aktualizovat datapole
        }

        private void RemoveRecord_Click(object sender, EventArgs e)
        {
            int index = PasswordViewer.SelectedRows[0].Index; //Zjistit zvolený řádek
            database.RemoveAt(index);
            PasswordViewer.DataSource = null; //Oprava chyby s aktualizací datapole
            PasswordViewer.DataSource = database; //Aktualizovat datapole
        }

        private void EditRecord_Click(object sender, EventArgs e)
        {
            int index = PasswordViewer.SelectedRows[0].Index; //Zjistit zvolený řádek
            record n = new record();
            //Nahrát informace z textových polí
            n.Stranka = StrankaBox.Text; 
            n.Jmeno = JmenoBox.Text;
            n.Heslo = HesloBox.Text;
            database[index] = n;
            PasswordViewer.DataSource = null; //Oprava chyby s aktualizací datapole
            PasswordViewer.DataSource = database; //Aktualizovat datapole
        }

        private void CreateButton_Click(object sender, EventArgs e)
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
