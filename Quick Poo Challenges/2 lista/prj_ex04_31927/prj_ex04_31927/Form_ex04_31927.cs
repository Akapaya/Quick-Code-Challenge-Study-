using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex04_31927
{
    public partial class Form_ex04_31927 : Form
    {
        int val1, val2, val3;
        public Form_ex04_31927()
        {
            InitializeComponent();
        }

        private void btcalc_Click(object sender, EventArgs e)
        {
            

            try
            {

                val1 = int.Parse(txtval1.Text);
                val2 = int.Parse(txtval2.Text);
            }
            catch {
                MessageBox.Show("insira somentes numeros");
                txtval1.Clear();
                txtval2.Clear();
                txtval3.Clear();
                txtval1.Focus();
                return;
            }

		val3 = val1 * val2;

            if (val3 > 100)

            		{
				txtval3.Text = val3.ToString();
				lblobs.Text = ("o terreno é grande");
            		}
		
	    else
		{
			txtval3.Text = val3.ToString();
		}

        }

        private void Form_ex04_31927_Load(object sender, EventArgs e)
        {

        }

        private void btlim_Click(object sender, EventArgs e)
        {
            txtval1.Clear();
            txtval2.Clear();
            txtval3.Clear();
        }

        private void btsai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }
     }
}
