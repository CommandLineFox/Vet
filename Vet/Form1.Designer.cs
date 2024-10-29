namespace Vet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbPretragaVlasnik = new System.Windows.Forms.RadioButton();
            this.rbPretragaPacijent = new System.Windows.Forms.RadioButton();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btObrisi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbAnamneza = new System.Windows.Forms.Label();
            this.lbDijagnoza = new System.Windows.Forms.Label();
            this.rtbAnamneza = new System.Windows.Forms.RichTextBox();
            this.cbKartoni = new System.Windows.Forms.ComboBox();
            this.rtbKlinickaSlika = new System.Windows.Forms.RichTextBox();
            this.lbKlinickaSlika = new System.Windows.Forms.Label();
            this.rtbTerapija = new System.Windows.Forms.RichTextBox();
            this.lbTerapija = new System.Windows.Forms.Label();
            this.lbNapomena = new System.Windows.Forms.Label();
            this.rtbNapomena = new System.Windows.Forms.RichTextBox();
            this.rtbDijagnoza = new System.Windows.Forms.RichTextBox();
            this.btNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPretragaVlasnik
            // 
            this.rbPretragaVlasnik.AutoSize = true;
            this.rbPretragaVlasnik.Location = new System.Drawing.Point(83, 7);
            this.rbPretragaVlasnik.Name = "rbPretragaVlasnik";
            this.rbPretragaVlasnik.Size = new System.Drawing.Size(65, 17);
            this.rbPretragaVlasnik.TabIndex = 1;
            this.rbPretragaVlasnik.TabStop = true;
            this.rbPretragaVlasnik.Text = "Vlasniku";
            this.rbPretragaVlasnik.UseVisualStyleBackColor = true;
            this.rbPretragaVlasnik.CheckedChanged += new System.EventHandler(this.RbPretragaVlasnik_CheckedChanged);
            // 
            // rbPretragaPacijent
            // 
            this.rbPretragaPacijent.AutoSize = true;
            this.rbPretragaPacijent.Location = new System.Drawing.Point(154, 7);
            this.rbPretragaPacijent.Name = "rbPretragaPacijent";
            this.rbPretragaPacijent.Size = new System.Drawing.Size(69, 17);
            this.rbPretragaPacijent.TabIndex = 2;
            this.rbPretragaPacijent.TabStop = true;
            this.rbPretragaPacijent.Text = "Pacijentu";
            this.rbPretragaPacijent.UseVisualStyleBackColor = true;
            this.rbPretragaPacijent.CheckedChanged += new System.EventHandler(this.RbPretragaVlasnik_CheckedChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(12, 9);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(65, 13);
            this.lblPretraga.TabIndex = 3;
            this.lblPretraga.Text = "Pretraga po:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 56);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(689, 479);
            this.dgv.TabIndex = 4;
            this.dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_CellMouseDoubleClick);
            // 
            // tbPretraga
            // 
            this.tbPretraga.Location = new System.Drawing.Point(12, 30);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(211, 20);
            this.tbPretraga.TabIndex = 6;
            this.tbPretraga.TextChanged += new System.EventHandler(this.TbPretraga_TextChanged);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(775, 56);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 23);
            this.btDodaj.TabIndex = 7;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(856, 56);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btIzmeni.TabIndex = 8;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            // 
            // btObrisi
            // 
            this.btObrisi.Location = new System.Drawing.Point(937, 56);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(75, 23);
            this.btObrisi.TabIndex = 9;
            this.btObrisi.Text = "Obrisi";
            this.btObrisi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbAnamneza
            // 
            this.lbAnamneza.AutoSize = true;
            this.lbAnamneza.Location = new System.Drawing.Point(12, 33);
            this.lbAnamneza.Name = "lbAnamneza";
            this.lbAnamneza.Size = new System.Drawing.Size(57, 13);
            this.lbAnamneza.TabIndex = 11;
            this.lbAnamneza.Text = "Anamneza";
            // 
            // lbDijagnoza
            // 
            this.lbDijagnoza.AutoSize = true;
            this.lbDijagnoza.Location = new System.Drawing.Point(12, 198);
            this.lbDijagnoza.Name = "lbDijagnoza";
            this.lbDijagnoza.Size = new System.Drawing.Size(54, 13);
            this.lbDijagnoza.TabIndex = 12;
            this.lbDijagnoza.Text = "Dijagnoza";
            // 
            // rtbAnamneza
            // 
            this.rtbAnamneza.BackColor = System.Drawing.SystemColors.Window;
            this.rtbAnamneza.Location = new System.Drawing.Point(12, 49);
            this.rtbAnamneza.Name = "rtbAnamneza";
            this.rtbAnamneza.ReadOnly = true;
            this.rtbAnamneza.Size = new System.Drawing.Size(502, 54);
            this.rtbAnamneza.TabIndex = 13;
            this.rtbAnamneza.Text = "";
            // 
            // cbKartoni
            // 
            this.cbKartoni.FormattingEnabled = true;
            this.cbKartoni.Location = new System.Drawing.Point(15, 6);
            this.cbKartoni.Name = "cbKartoni";
            this.cbKartoni.Size = new System.Drawing.Size(133, 21);
            this.cbKartoni.TabIndex = 14;
            // 
            // rtbKlinickaSlika
            // 
            this.rtbKlinickaSlika.BackColor = System.Drawing.SystemColors.Window;
            this.rtbKlinickaSlika.Location = new System.Drawing.Point(12, 132);
            this.rtbKlinickaSlika.Name = "rtbKlinickaSlika";
            this.rtbKlinickaSlika.ReadOnly = true;
            this.rtbKlinickaSlika.Size = new System.Drawing.Size(502, 54);
            this.rtbKlinickaSlika.TabIndex = 15;
            this.rtbKlinickaSlika.Text = "";
            // 
            // lbKlinickaSlika
            // 
            this.lbKlinickaSlika.AutoSize = true;
            this.lbKlinickaSlika.Location = new System.Drawing.Point(12, 116);
            this.lbKlinickaSlika.Name = "lbKlinickaSlika";
            this.lbKlinickaSlika.Size = new System.Drawing.Size(68, 13);
            this.lbKlinickaSlika.TabIndex = 16;
            this.lbKlinickaSlika.Text = "Klinicka slika";
            // 
            // rtbTerapija
            // 
            this.rtbTerapija.BackColor = System.Drawing.SystemColors.Window;
            this.rtbTerapija.Location = new System.Drawing.Point(12, 298);
            this.rtbTerapija.Name = "rtbTerapija";
            this.rtbTerapija.ReadOnly = true;
            this.rtbTerapija.Size = new System.Drawing.Size(502, 54);
            this.rtbTerapija.TabIndex = 17;
            this.rtbTerapija.Text = "";
            // 
            // lbTerapija
            // 
            this.lbTerapija.AutoSize = true;
            this.lbTerapija.Location = new System.Drawing.Point(12, 282);
            this.lbTerapija.Name = "lbTerapija";
            this.lbTerapija.Size = new System.Drawing.Size(45, 13);
            this.lbTerapija.TabIndex = 18;
            this.lbTerapija.Text = "Terapija";
            // 
            // lbNapomena
            // 
            this.lbNapomena.AutoSize = true;
            this.lbNapomena.Location = new System.Drawing.Point(15, 366);
            this.lbNapomena.Name = "lbNapomena";
            this.lbNapomena.Size = new System.Drawing.Size(59, 13);
            this.lbNapomena.TabIndex = 20;
            this.lbNapomena.Text = "Napomena";
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.Location = new System.Drawing.Point(12, 382);
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.ReadOnly = true;
            this.rtbNapomena.Size = new System.Drawing.Size(502, 54);
            this.rtbNapomena.TabIndex = 21;
            this.rtbNapomena.Text = "";
            // 
            // rtbDijagnoza
            // 
            this.rtbDijagnoza.BackColor = System.Drawing.SystemColors.Window;
            this.rtbDijagnoza.Location = new System.Drawing.Point(12, 214);
            this.rtbDijagnoza.Name = "rtbDijagnoza";
            this.rtbDijagnoza.ReadOnly = true;
            this.rtbDijagnoza.Size = new System.Drawing.Size(502, 54);
            this.rtbDijagnoza.TabIndex = 22;
            this.rtbDijagnoza.Text = "";
            // 
            // btNazad
            // 
            this.btNazad.Location = new System.Drawing.Point(12, 512);
            this.btNazad.Name = "btNazad";
            this.btNazad.Size = new System.Drawing.Size(75, 23);
            this.btNazad.TabIndex = 23;
            this.btNazad.Text = "Nazad";
            this.btNazad.UseVisualStyleBackColor = true;
            this.btNazad.Click += new System.EventHandler(this.BtNazad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 547);
            this.Controls.Add(this.btNazad);
            this.Controls.Add(this.rtbDijagnoza);
            this.Controls.Add(this.rtbNapomena);
            this.Controls.Add(this.lbNapomena);
            this.Controls.Add(this.lbTerapija);
            this.Controls.Add(this.rtbTerapija);
            this.Controls.Add(this.lbKlinickaSlika);
            this.Controls.Add(this.rtbKlinickaSlika);
            this.Controls.Add(this.cbKartoni);
            this.Controls.Add(this.rtbAnamneza);
            this.Controls.Add(this.lbDijagnoza);
            this.Controls.Add(this.lbAnamneza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbPretragaPacijent);
            this.Controls.Add(this.rbPretragaVlasnik);
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblPretraga);
            this.Name = "Form1";
            this.Text = "Vet 1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbPretragaVlasnik;
        private System.Windows.Forms.RadioButton rbPretragaPacijent;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btObrisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbAnamneza;
        private System.Windows.Forms.Label lbDijagnoza;
        private System.Windows.Forms.RichTextBox rtbAnamneza;
        private System.Windows.Forms.ComboBox cbKartoni;
        private System.Windows.Forms.RichTextBox rtbKlinickaSlika;
        private System.Windows.Forms.Label lbKlinickaSlika;
        private System.Windows.Forms.Label lbTerapija;
        private System.Windows.Forms.Label lbNapomena;
        private System.Windows.Forms.RichTextBox rtbNapomena;
        private System.Windows.Forms.RichTextBox rtbDijagnoza;
        private System.Windows.Forms.RichTextBox rtbTerapija;
        private System.Windows.Forms.Button btNazad;
    }
}

