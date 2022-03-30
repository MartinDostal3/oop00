using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Student std = new Student();
            Student std = new Student("Lakatoš");
            

            std.OznamkujCJL(3);
            std.OznamkujMAT(2);
            std.OznamkujPRG(1);
           
            

            double p = std.Prumer();
            if(p !=-1)
            {
                MessageBox.Show(std.GetJmeno() + " má průměr známek: " + p);
            }
            else
            {
                MessageBox.Show(std.GetJmeno() + " neni klasifikován");
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student std2 = new Student("Armando", 1, 3, 1);
            double p = std2.Prumer();
            if (p != -1)
            {
                MessageBox.Show(std2.GetJmeno() + " má průměr známek: " + p);
            }
            else
            {
                MessageBox.Show(std2.GetJmeno() + " neni klasifikován");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student std3 = new Student("Ferrari", 1, 1, 2, "Tomáše Bati 1088");
            MessageBox.Show(std3.GetJmeno() + " bydlí v " + std3.GetBydliste());
            std3.SetBydliste("Pičín");
            MessageBox.Show(std3.GetJmeno() + " se přestěhoval do " + std3.GetBydliste());

            Student std4 = new Student("Gopál", "Kozodírky");
            MessageBox.Show(std4.GetJmeno() + " bydlí v " + std4.GetBydliste());

        }
    }
}
