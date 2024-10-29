using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet
{
    class Pacijent
    {
        #region Atributi
        private int id_vlasnika;
        private int id_pacijenta;
        private string ime;
        private DateTime datum_rodjenja;
        private string vrsta;
        private string rasa;
        private string pol;
        private string broj_pasosa;
        private string broj_mikrocipa;
        private List<Karton> kartoni;
        #endregion
        #region Konstruktori
        public Pacijent()
        {
            id_vlasnika = 0;
            id_pacijenta = 0;
            ime = "";
            datum_rodjenja = DateTime.Now;
            vrsta = "";
            rasa = "";
            pol = "";
            broj_pasosa = "";
            broj_mikrocipa = "";
            kartoni = new List<Karton>();
        }
        #endregion
        #region Svojstva
        public int Id_vlasnika
        {
            get
            {
                return id_vlasnika;
            }
            set
            {
                id_vlasnika = value;
            }
        }
        public int Id_Pacijenta
        {
            set
            {
                id_pacijenta = value;
            }
        }
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Ime ne moze da bude prazno.");
                }
                else
                {
                    ime = value;
                }
            }
        }
        public DateTime Datum_Rodjenja
        {
            get
            {
                return datum_rodjenja;
            }
            set
            {
                datum_rodjenja = value;
            }
        }
        public string Broj_Pasosa
        {
            get
            {
                return broj_pasosa;
            }
            set
            {
                broj_pasosa = value;
            }
        }
        public string Broj_Mikrocipa
        {
            get
            {
                return broj_mikrocipa;
            }
            set
            {
                broj_mikrocipa = value;
            }
        }
        public List<Karton> Kartoni
        {
            get
            {
                return kartoni;
            }
            set
            {
                kartoni = value;
            }
        }
        public string Pol
        {
            get
            {
                return pol;
            }
            set
            {
                pol = value;
            }
        }
        public string Vrsta
        {
            get
            {
                return vrsta;
            }
            set
            {
                vrsta = value;
            }
        }
        public string Rasa
        {
            get
            {
                return rasa;
            }
            set
            {
                rasa = value;
            }
        }
        #endregion
        #region Metode
        public void Citaj(StreamReader f)
        {
            id_vlasnika = int.Parse(f.ReadLine());
            id_pacijenta = int.Parse(f.ReadLine());
            ime = f.ReadLine();

            string[] datum_string = f.ReadLine().Split('.');
            datum_rodjenja = new DateTime(int.Parse(datum_string[2]), int.Parse(datum_string[1]), int.Parse(datum_string[0]));

            vrsta = f.ReadLine();
            rasa = f.ReadLine();
            pol = f.ReadLine();
            broj_pasosa = f.ReadLine();
            broj_mikrocipa = f.ReadLine();
            kartoni = new List<Karton>();
        }
        public void Pisi(StreamWriter f)
        {
            f.WriteLine(id_vlasnika);
            f.WriteLine(id_pacijenta);
            f.WriteLine(ime);
            f.WriteLine(datum_rodjenja.Day + "." + datum_rodjenja.Month + "." + datum_rodjenja.Year);
            f.WriteLine(vrsta);
            f.WriteLine(rasa);
            f.WriteLine(pol);
            f.WriteLine(broj_pasosa);
            f.WriteLine(broj_mikrocipa);
        }
        public void DodajKartone(List<Karton> kartoni)
        {
            foreach (Karton karton in kartoni)
            {
                if (karton.Id_pacijenta == id_pacijenta)
                {
                    this.kartoni.Add(karton);
                }
            }
        }
        #endregion
    }
}