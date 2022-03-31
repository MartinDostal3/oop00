using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop00
{
    class Osoba
    {
        private string jmeno;
        private string prijmeni;
        private int vyska;
        private double vaha;

        public Osoba(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public Osoba(string jmeno, string prijmeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
        }
        public Osoba(string jmeno, string prijmeni, int vyska, double vaha)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vyska = vyska;
            this.vaha = vaha;

        }

        public string GetJmeno()
        {
            return jmeno;
        }

        // public string SetJmeno()   nedovolime

        public string GetPrijmeni()
        {
            return prijmeni;
        }
        public void SetPrijmeni(string prijmeni)
        {
            this.prijmeni = prijmeni;
            return;
        }

        public string CeleJmenoVelkymi()
        {
            string s = jmeno.ToUpper() + " " + prijmeni.ToUpper();

            return s;
        }

        public override string ToString()
        {
            string s = "\nJmeno: " + jmeno
               + "\nPrijmeni: " + prijmeni
               + "\nCele jmeno velkymi: " + CeleJmenoVelkymi();


            return base.ToString() + s;
        }




    }
}
