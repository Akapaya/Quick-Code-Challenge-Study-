using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex08_31927
{
    public partial class Form_ex08_31927 : Form
    {
        int val1, val2, val3, p1, p2, p3;
        string conf;

        public Form_ex08_31927()
        {
            InitializeComponent();
        }

        private void btcalc_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = int.Parse(txtval1.Text);
                val2 = int.Parse(txtval2.Text);
                val3 = int.Parse(txtval3.Text);
            }
            catch
            {
                MessageBox.Show("insira somente numeros");
                txtval1.Clear();
                txtval2.Clear();
                txtval3.Clear();
            }

            p1 = val1 + val2;
            p2 = val1 + val3;
            p3 = val2 + val3;

            if (p1 > val3 && p2 > val2 && p3 > val1)
            {
                conf = "P";
            }
            else
            {
                lblobs.Text = ("não é triangulo");
            }
            if (conf == "P")
            {
                if (val1 != val2 && val1 != val3 && val2 != val3)
                {
                    lblobs.Text = ("o triangulo é escaleno");
                }
                else
                {
                    if (val1 == val2 && val2 != val3 || val2 == val3 && val3 != val1 || val3 == val1 && val1 != val2)
                    {
                        lblobs.Text = ("o triangulo é isoceles");
                    }
                    else
                    {
                        if (val1 == val2 && val1 == val3)
                        {
                            lblobs.Text = ("o triangulo é equilatero");
                        }
                        else
                        {
                        }
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
