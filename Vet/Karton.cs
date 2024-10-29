using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vet
{
    class Karton
    {
        #region Atributi
        private int id_pacijenta;
        private DateTime datum;
        private string anamneza;
        private string klinicka_slika;
        private string dijagnoza;
        private string terapija;
        private string napomena;
        #endregion
        #region Konstruktori
        public Karton()
        {
            id_pacijenta = 0;
            datum = DateTime.Now;
            anamneza = "";
            klinicka_slika = "";
            dijagnoza = "";
            terapija = "";
            napomena = "";
        }
        #endregion
        #region Svojstva
        public int Id_pacijenta
        {
            get
            {
                return id_pacijenta;
            }
            set
            {
                id_pacijenta = value;
            }
        }
        public DateTime Datum
        {
            get
            {
                return datum;
            }
            set
            {
                datum = value;
            }
        }
        public string Anamneza
        {
            get
            {
                return anamneza;
            }
            set
            {
                anamneza = value;
            }
        }
        public string Klinicka_Slika
        {
            get
            {
                return klinicka_slika;
            }
            set
            {
                klinicka_slika = value;
            }
        }
        public string Dijagnoza
        {
            get
            {
                return dijagnoza;
            }
            set
            {
                dijagnoza = value;
            }
        }
        public string Terapija
        {
            get
            {
                return terapija;
            }
            set
            {
                terapija = value;
            }
        }
        public string Napomena
        {
            get
            {
                return napomena;
            }
            set
            {
                napomena = value;
            }
        }
        #endregion
        #region Metode
        public void Citaj(StreamReader f)
        {
            id_pacijenta = int.Parse(f.ReadLine());

            string[] datum_string = f.ReadLine().Split('.');
            datum = new DateTime(int.Parse(datum_string[2]), int.Parse(datum_string[1]), int.Parse(datum_string[0]));

            anamneza = f.ReadLine();
            klinicka_slika = f.ReadLine();
            dijagnoza = f.ReadLine();
            terapija = f.ReadLine();
            napomena = f.ReadLine();
        }

        public void Pisi(StreamWriter f)
        {
            f.WriteLine(id_pacijenta);
            f.WriteLine(datum.Day + "." + datum.Month + " " + datum.Year);
            f.WriteLine(anamneza);
            f.WriteLine(klinicka_slika);
            f.WriteLine(dijagnoza);
            f.WriteLine(terapija);
            f.WriteLine(napomena);
        }
        #endregion
    }
}