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
        public int GetVyska()
        {
            return vyska;
        }
        public void SetVyska(int vyska)
        {
            if (vyska > 15 && vyska < 250)
            {
                this.vyska = vyska;
            }
            return;
        }

        public double GetVaha()
        {
            return vaha;
        }
        public void SetVaha(double vaha)
        {
            if(vaha > 1 && vaha < 350)
            {
                this.vaha = vaha;
            }
            
            return;
        }
        public double BMI(double vaha, int vyska)
        {
            

            return vaha / Math.Pow((vyska/100), 2);
        }

        public override string ToString()
        {
            string s = "\nJmeno: " + jmeno
               + "\nPrijmeni: " + prijmeni
               + "\nCele jmeno velkymi: " + CeleJmenoVelkymi()
               +"\nVyska: " + vyska + " cm"
               +"\nVaha: " + vaha +" kg"
               +"\nBMI: " + BMI(vaha, vyska);


            return base.ToString() + s;
        }




    }
}
