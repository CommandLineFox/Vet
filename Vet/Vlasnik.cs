using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet
{
    class Vlasnik
    {
        #region Atributi
        private int id_vlasnika;
        private string ime;
        private string prezime;
        private string telefon;
        private string adresa;
        private List<Pacijent> ljubimci;
        #endregion
        #region Konstruktori
        public Vlasnik()
        {
            id_vlasnika = 0;
            ime = "";
            prezime = "";
            telefon = "";
            adresa = "";
            ljubimci = new List<Pacijent>();
        }
        #endregion
        #region Svojstva
        public int Id_Vlasnika
        {
            set
            {
                id_vlasnika = value;
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
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Prezime ne moze da bude prazno");
                }
                else
                {
                    prezime = value;
                }
            }
        }
        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("");
                }
                else
                {
                    telefon = value;
                }
            }
        }
        public string Adresa
        {
            get
            {
                return adresa;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("");
                }
                else
                {
                    adresa = value;
                }
            }
        }
        public List<Pacijent> Ljubimci
        {
            get
            {
                return ljubimci;
            }
            set
            {
                ljubimci = value;
            }
        }
        #endregion
        #region Metode
        public void Citaj(StreamReader f)
        {
            id_vlasnika = int.Parse(f.ReadLine());

            string[] ip = f.ReadLine().Split(' ');
            ime = ip[0];
            prezime = ip[1];

            telefon = f.ReadLine();
            adresa = f.ReadLine();
            ljubimci = new List<Pacijent>();
        }
        public void Pisi(StreamWriter f)
        {
            f.WriteLine(id_vlasnika);
            f.WriteLine(ime + " " + prezime);
            f.WriteLine(telefon);
            f.WriteLine(adresa);
        }
        public void DodajLjubimce(List<Pacijent> pacijenti)
        {
            foreach (Pacijent pacijent in pacijenti)
            {
                if (pacijent.Id_vlasnika == id_vlasnika)
                {
                    ljubimci.Add(pacijent);
                }
            }
        }
        #endregion
    }
}