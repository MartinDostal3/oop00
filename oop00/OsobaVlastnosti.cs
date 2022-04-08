using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop00
{
    class OsobaVlastnosti
    {
        //private string jmeno;
        //public string Jmeno
        //{
        //    get
        //    {
        //        return jmeno;
        //    }
        //    private set
        //    {
        //        jmeno = value;
        //    }
        //}
        public string Jmeno { get;  } //{get; private set;}

        //private string prijmeni;
        //public string Prijmeni
        //{
        //    get
        //    {
        //        return prijmeni;
        //    }
        //    set
        //    {
        //        prijmeni = value;
        //    }

        //}
        public string Prijmeni { get; set}
        private int vyska;
        public int Vyska
        {
            get
            {
                return vyska;
            }
            set
            {
                if (value > 15 && value < 250)
                {
                    vyska = value;
                }
                
               
            }

        }

        private double vaha;
        public double Vaha
        {
            get
            {
                return vaha;
            }
            set
            {
                if (value > 1 && value < 350)
                {
                    vaha = value;
                }


            }

        }






        public OsobaVlastnosti(string jmeno)
        {
            Jmeno = jmeno;
        }
        public OsobaVlastnosti(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
           Prijmeni = prijmeni;
        }
        public OsobaVlastnosti(string jmeno, string prijmeni, int vyska, double vaha)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vyska = vyska;
            Vaha = vaha;

        }

        public override string ToString()
        {
            string s = "\nJmeno: " + Jmeno
                + "\nPrijmeni: " + Prijmeni
                + "\nVyska: " + Vyska + " cm"
               + "\nVaha: " + Vaha + " kg";
               


            return base.ToString() + s;
        }



    }
}
