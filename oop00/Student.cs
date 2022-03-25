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

        //public Student()
        //{

        //}
        public Student(string jmeno)
        {
           this.jmeno = jmeno;
           
        }
        public Student(string jmeno, int znamkaCJL, int znamkaMAT, int znamkaPRG)
        {
            this.jmeno = jmeno;
            this.znamkaCJL = znamkaCJL;
            this.znamkaMAT = znamkaMAT;
            this.znamkaPRG = znamkaPRG;
        }
        public string GetJmeno()
        {
            return jmeno;
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
