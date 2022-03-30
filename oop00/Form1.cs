﻿using System;
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
            Student std1 = new Student("Ferrari", 1, 1, 2, "Tomáše Bati 1088");
            MessageBox.Show(std1.GetJmeno() + " bydlí v " + std1.GetBydliste());
            std1.SetBydliste("Pičín");
            MessageBox.Show(std1.GetJmeno() + " se přestěhoval do " + std1.GetBydliste());

            Student std2 = new Student("Gopál", "Kozodírky");
            MessageBox.Show(std2.GetJmeno() + " bydlí v " + std2.GetBydliste());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student std1 = new Student("Mrdáč", 1, 1, 1, "Stařeč");

            MessageBox.Show(std1.ToString());
            MessageBox.Show(textBox1.ToString());
        }
    }
}
