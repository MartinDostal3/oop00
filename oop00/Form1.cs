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
            std.OznamkujMAT(1);
           
            

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
    }
}
