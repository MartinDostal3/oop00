using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop00
{
    class Student
    {

        private string jmeno;
        private int znamkaCJL;
        private int znamkaMAT;
        private int znamkaPRG;
        private string bydliste;

        //public Student()
        //{

        //}
        public Student(string jmeno)
        {
            this.jmeno = jmeno;

        }
        public Student(string jmeno, string bydliste)
        {
            this.jmeno = jmeno;
            this.bydliste = bydliste;
        }
        public Student(string jmeno, int znamkaCJL, int znamkaMAT, int znamkaPRG)
        {
            this.jmeno = jmeno;
            this.znamkaCJL = znamkaCJL;
            this.znamkaMAT = znamkaMAT;
            this.znamkaPRG = znamkaPRG;
        }
        public Student(string jmeno, int znamkaCJL, int znamkaMAT, int znamkaPRG, string bydliste)
        {
            this.jmeno = jmeno;
            this.znamkaCJL = znamkaCJL;
            this.znamkaMAT = znamkaMAT;
            this.znamkaPRG = znamkaPRG;
            this.bydliste = bydliste;
        }
        public string GetJmeno()
        {
            return jmeno;
        }

        public string GetBydliste()
        {
            return bydliste;
        }
        public void SetBydliste(string bydliste)
        {
            this.bydliste = bydliste;
            return;
        }
        
        public void OznamkujCJL(int znamka)
        {
            if (znamka > 0 && znamka < 6) znamkaCJL = znamka;

            return;
        }
        public void OznamkujMAT( int znamka )
        {
            if (znamka > 0 && znamka < 6) znamkaMAT = znamka;

            return;
        }
        
        public void OznamkujPRG(int znamka)
        {
            if (znamka > 0 && znamka < 6) znamkaPRG = znamka;

            return;
        }

        public double Prumer()
        {
            if(znamkaCJL != 0 && znamkaMAT !=0 && znamkaPRG != 0)
            {
                return (double)(znamkaCJL + znamkaMAT + znamkaPRG) / 3;
            }
            else
            {
                return -1;
            }

            
        }



    }
}
