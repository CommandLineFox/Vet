using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Vlasnik> vlasnici;
        private void Form1_Load(object sender, EventArgs e)
        {
            vlasnici = new List<Vlasnik>();

            Ucitaj();
            PrikaziPretragu();
            PostaviDGV(dgv, 300, 7, 100, 20);
        }
        #region Prikazivanje
        private void PostaviDGV(DataGridView dgv, int n, int m, int w, int h)
        {
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;

            dgv.RowCount = n;
            dgv.ColumnCount = m;
            dgv.RowHeadersWidth = 24;
            dgv.Width = m * w + 20 + dgv.RowHeadersWidth;
            dgv.Height = n * h + 18 + dgv.ColumnHeadersHeight;

            if (dgv.ColumnHeadersHeight + dgv.Location.Y + dgv.Height > Height)
            {
                dgv.Height = Height - dgv.Location.Y - dgv.ColumnHeadersHeight - 29;
            }

            for (int i = 0; i < n; i++)
            {
                dgv.Rows[i].Height = h;
            }
            for (int i = 0; i < m; i++)
            {
                dgv.Columns[i].Width = w;
            }

            dgv.Columns[0].HeaderText = "Broj pasosa";
            dgv.Columns[1].HeaderText = "Broj mikrocipa";
            dgv.Columns[2].HeaderText = "Ime";
            dgv.Columns[5].HeaderText = "Vrsta zivotinje";
            dgv.Columns[6].HeaderText = "Rasa";
            dgv.Columns[4].HeaderText = "Pol";
            dgv.Columns[3].HeaderText = "Datum rodjenja";
        }

        private void PrikaziPretragu()
        {
            cbKartoni.Visible = false;
            lbAnamneza.Visible = false;
            rtbAnamneza.Visible = false;
            lbKlinickaSlika.Visible = false;
            rtbKlinickaSlika.Visible = false;
            lbDijagnoza.Visible = false;
            rtbDijagnoza.Visible = false;
            lbTerapija.Visible = false;
            rtbTerapija.Visible = false;
            lbNapomena.Visible = false;
            rtbNapomena.Visible = false;
            btNazad.Visible = false;

            lblPretraga.Visible = true;
            rbPretragaPacijent.Visible = true;
            rbPretragaVlasnik.Visible = true;
            tbPretraga.Visible = true;
            dgv.Visible = true;
        }

        private void PrikaziKartone()
        {
            cbKartoni.Visible = true;
            lbAnamneza.Visible = true;
            rtbAnamneza.Visible = true;
            lbKlinickaSlika.Visible = true;
            rtbKlinickaSlika.Visible = true;
            lbDijagnoza.Visible = true;
            rtbDijagnoza.Visible = true;
            lbTerapija.Visible = true;
            rtbTerapija.Visible = true;
            lbNapomena.Visible = true;
            rtbNapomena.Visible = true;
            btNazad.Visible = true;

            lblPretraga.Visible = false;
            rbPretragaPacijent.Visible = false;
            rbPretragaVlasnik.Visible = false;
            tbPretraga.Visible = false;
            dgv.Visible = false;
        }
        #endregion
        #region Pisanje i citanje iz fajlova
        private void Ucitaj()
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            List<Karton> kartoni = new List<Karton>();

            StreamReader k = new StreamReader("kartoni.txt");
            while (!k.EndOfStream)
            {
                Karton karton = new Karton();
                karton.Citaj(k);
                kartoni.Add(karton);
            }

            StreamReader p = new StreamReader("pacijenti.txt");
            while (!p.EndOfStream)
            {
                Pacijent pacijent = new Pacijent();
                pacijent.Citaj(p);
                pacijenti.Add(pacijent);
                pacijent.DodajKartone(kartoni);
            }

            StreamReader v = new StreamReader("vlasnici.txt");
            while (!v.EndOfStream)
            {
                Vlasnik vlasnik = new Vlasnik();
                vlasnik.Citaj(v);
                vlasnici.Add(vlasnik);
                vlasnik.DodajLjubimce(pacijenti);
            }

            v.Close();
            p.Close();
            k.Close();
        }

        public void Upisi()
        {
            StreamWriter v = new StreamWriter("vlasnici.txt");
            StreamWriter p = new StreamWriter("pacijenti.txt");
            StreamWriter k = new StreamWriter("kartoni.txt");

            foreach (Vlasnik vlasnik in vlasnici)
            {
                vlasnik.Pisi(v);

                foreach (Pacijent pacijent in vlasnik.Ljubimci)
                {
                    pacijent.Pisi(p);

                    foreach (Karton karton in pacijent.Kartoni)
                    {
                        karton.Pisi(k);
                    }
                }
            }

            v.Close();
            p.Close();
            k.Close();
        }
        #endregion
        #region Pretraga
        private string KonvertujTekst(string tekst)
        {
            string rezultat = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == ' ' && i > 0 && tekst[i - 1] == ' ')
                {
                    continue;
                }
                if (tekst[i] == 'š')
                {
                    rezultat += 's';
                }
                else if (tekst[i] == 'č' || tekst[i] == 'ć')
                {
                    rezultat += 'c';
                }
                else if (tekst[i] == 'đ')
                {
                    rezultat += "dj";
                }
                else
                {
                    rezultat += tekst[i];
                }
            }

            return rezultat;
        }

        private List<Pacijent> Pronadji()
        {
            List<Pacijent> nadjeni = new List<Pacijent>();
            string pretraga = KonvertujTekst(tbPretraga.Text);

            if (rbPretragaVlasnik.Checked)
            {
                foreach (Vlasnik vlasnik in vlasnici)
                {
                    if (KonvertujTekst(vlasnik.Ime).Contains(pretraga) || KonvertujTekst(vlasnik.Prezime).Contains(pretraga) || vlasnik.Telefon.Contains(pretraga) || KonvertujTekst(vlasnik.Adresa).Contains(pretraga))
                    {
                        foreach (Pacijent pacijent in vlasnik.Ljubimci)
                        {
                            nadjeni.Add(pacijent);
                        }
                    }
                    else if ((KonvertujTekst(vlasnik.Ime).Contains(pretraga.Split(' ')[0]) || KonvertujTekst(vlasnik.Ime).Contains(pretraga.Split(' ')[1])) && (KonvertujTekst(vlasnik.Prezime).Contains(pretraga.Split(' ')[0]) || KonvertujTekst(vlasnik.Prezime).Contains(pretraga.Split(' ')[1])))
                    {
                        foreach (Pacijent pacijent in vlasnik.Ljubimci)
                        {
                            nadjeni.Add(pacijent);
                        }
                    }
                }
            }
            else if (rbPretragaPacijent.Checked)
            {
                foreach (Vlasnik vlasnik in vlasnici)
                {
                    foreach (Pacijent pacijent in vlasnik.Ljubimci)
                    {
                        if (pacijent.Ime.Contains(pretraga) || pacijent.Broj_Mikrocipa.Contains(pretraga) || pacijent.Broj_Pasosa.Contains(pretraga))
                        {
                            nadjeni.Add(pacijent);
                        }
                    }
                }
            }
            return nadjeni;
        }
        #endregion
        private void TbPretraga_TextChanged(object sender, EventArgs e)
        {
            List<Pacijent> nadjeni = Pronadji();

            PostaviDGV(dgv, nadjeni.Count, 7, 100, 20);
            for (int i = 0; i < nadjeni.Count; i++)
            {
                dgv[i, 0].Value = nadjeni[i].Broj_Pasosa;
                dgv[i, 1].Value = nadjeni[i].Broj_Mikrocipa;
                dgv[i, 2].Value = nadjeni[i].Ime;
                dgv[i, 5].Value = nadjeni[i].Vrsta;
                dgv[i, 6].Value = nadjeni[i].Rasa;
                dgv[i, 4].Value = nadjeni[i].Pol;
                dgv[i, 3].Value = nadjeni[i].Datum_Rodjenja.Day + "." + nadjeni[i].Datum_Rodjenja.Month + "." + nadjeni[i].Datum_Rodjenja.Year + ".";
            }
        }

        private void RbPretragaVlasnik_CheckedChanged(object sender, EventArgs e)
        {
            tbPretraga.Text = "";
        }

        private void BtNazad_Click(object sender, EventArgs e)
        {
            PrikaziPretragu();
        }

        private void Dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int izabarano = e.RowIndex;
            PrikaziKartone();
        }
    }
}