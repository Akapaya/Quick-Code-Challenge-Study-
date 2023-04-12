using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex10_31927
{
    public partial class Form_ex10_31927 : Form
    {
        int val1, val2, val3;
        public Form_ex10_31927()
        {
            InitializeComponent();
        }

        private void btcalc_Click(object sender, EventArgs e)
        {
            val1 = int.Parse(txtval1.Text);
            val2 = int.Parse(txtval2.Text);
            if (chema.Checked)
            {
                val3 = val1 / val2 ^ 2;
                if (val3 < 20)
                {
                    MessageBox.Show("Abaixo do peso");
                }
                else
                {
                    if (val3 >= 25)
                    {
                        MessageBox.Show("Acima do peso");
                    }
                    else
                    {
                        MessageBox.Show("Peso ideal");
                    }
                }
            }

            if (chefe.Checked)
            {
                val3 = val1 / val2 ^ 2;
                if (val3 < 19)
                {
                    MessageBox.Show("Abaixo do peso");
                }
                else
                {
                    if (val3 >= 24)
                    {
                        MessageBox.Show("Acima do peso");
                    }
                    else
                    {
                        MessageBox.Show("Peso ideal");
                    }
                }
            }


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
