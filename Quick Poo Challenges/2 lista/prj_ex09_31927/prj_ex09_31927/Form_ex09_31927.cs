using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex09_31927
{
    

    public partial class Form_ex09_31927 : Form
    {
        int val1, val2, val3;
        public Form_ex09_31927()
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
                MessageBox.Show("insira somentes numeros");
                txtval1.Clear();
                txtval2.Clear();
                txtval3.Clear();
                txtval1.Focus();
                return;
            }

            if (val1 > val2 && val1 > val3)
            {
                if (val1 == val2 + val3)
                {
                    MessageBox.Show("triangulo retangulo");
                    lblobs.Text = ("triangulo retangulo");
                }
            }
            else
            {
                MessageBox.Show("não é triangulo retangulo");
                lblobs.Text = ("não é triangulo");
            }

            if (val2 > val3 && val2 > val1)
            {
                if (val2 == val1 + val3)
                {
                    MessageBox.Show("triangulo retangulo");
                    lblobs.Text = ("triangulo retangulo");
                }
            }
            else
            {
                MessageBox.Show("não é triangulo retangulo");
                lblobs.Text = ("não é triangulo");
            }

            if (val3 > val2 && val3 > val1)
            {
                if (val3 == val2 + val1)
                {
                    MessageBox.Show("triangulo retangulo");
                    lblobs.Text = ("triangulo retangulo");
                }
            }
            else
            {
                MessageBox.Show("não é triangulo retangulo");
                lblobs.Text = ("não é triangulo");
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
