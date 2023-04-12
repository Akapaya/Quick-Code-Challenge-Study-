using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prj_Palíndromo_31927
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttcheck_Click(object sender, EventArgs e)
        {
            string name, um;

            Console.WriteLine("Escreva a palavra");
            name = Console.ReadLine();
            if (name.Substring(0, 1) == name.Substring(name.Length - 1, 1))
            {
                textBox1.Text = "igual";
            }
            else
            { 
            }
            Console.ReadKey();
        }
    }
}
