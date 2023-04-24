namespace SmichovPass
{
    partial class App
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordViewer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.StrankaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JmenoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HesloBox = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddRecord = new System.Windows.Forms.Button();
            this.RemoveRecord = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordViewer
            // 
            this.PasswordViewer.AllowUserToAddRows = false;
            this.PasswordViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PasswordViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.PasswordViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PasswordViewer.Location = new System.Drawing.Point(424, 131);
            this.PasswordViewer.Name = "PasswordViewer";
            this.PasswordViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PasswordViewer.Size = new System.Drawing.Size(370, 301);
            this.PasswordViewer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "SmichovPass";
            // 
            // StrankaBox
            // 
            this.StrankaBox.Location = new System.Drawing.Point(23, 209);
            this.StrankaBox.Name = "StrankaBox";
            this.StrankaBox.Size = new System.Drawing.Size(301, 20);
            this.StrankaBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Název stránky (služby)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uživatelské jméno";
            // 
            // JmenoBox
            // 
            this.JmenoBox.Location = new System.Drawing.Point(23, 300);
            this.JmenoBox.Name = "JmenoBox";
            this.JmenoBox.Size = new System.Drawing.Size(301, 20);
            this.JmenoBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Heslo";
            // 
            // HesloBox
            // 
            this.HesloBox.Location = new System.Drawing.Point(23, 387);
            this.HesloBox.Name = "HesloBox";
            this.HesloBox.Size = new System.Drawing.Size(301, 20);
            this.HesloBox.TabIndex = 7;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(424, 438);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(194, 23);
            this.CopyButton.TabIndex = 10;
            this.CopyButton.Text = "Kopírovat zvolené heslo do schránky";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(695, 72);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 53);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Uložit soubor";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadButton.Location = new System.Drawing.Point(568, 72);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(121, 53);
            this.LoadButton.TabIndex = 12;
            this.LoadButton.Text = "Načíst soubor";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(390, 104);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(172, 20);
            this.KeyBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(386, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Klíč souboru";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\xenom\\Desktop\\SmichovPass\\source\\SmichovPass\\SSPS Logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(613, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // AddRecord
            // 
            this.AddRecord.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddRecord.Location = new System.Drawing.Point(217, 415);
            this.AddRecord.Name = "AddRecord";
            this.AddRecord.Size = new System.Drawing.Size(107, 39);
            this.AddRecord.TabIndex = 16;
            this.AddRecord.Text = "Přidat heslo";
            this.AddRecord.UseVisualStyleBackColor = true;
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // RemoveRecord
            // 
            this.RemoveRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveRecord.Location = new System.Drawing.Point(673, 438);
            this.RemoveRecord.Name = "RemoveRecord";
            this.RemoveRecord.Size = new System.Drawing.Size(121, 23);
            this.RemoveRecord.TabIndex = 17;
            this.RemoveRecord.Text = "Odebrat zvolené heslo";
            this.RemoveRecord.UseVisualStyleBackColor = true;
            this.RemoveRecord.Click += new System.EventHandler(this.RemoveRecord_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 46);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nové heslo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(838, 495);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RemoveRecord);
            this.Controls.Add(this.AddRecord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HesloBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JmenoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StrankaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordViewer);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SmichovPass";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PasswordViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StrankaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox JmenoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HesloBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddRecord;
        private System.Windows.Forms.Button RemoveRecord;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
    }
}

