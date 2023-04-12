using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex02_31927
{
    public partial class Form_ex02_31927 : Form
    {
        int val1, val2;
        public Form_ex02_31927()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmenor_Click(object sender, EventArgs e)
        {
            try
            {

                val1 = int.Parse(txtval1.Text);
                val2 = int.Parse(txtval2.Text);
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
            if (val1 < val2)
            {
                txtval3.Text = val1.ToString();
            }

            else
            {
                txtval3.Text = val2.ToString();
            }
        }

        private void btnlim_Click(object sender, EventArgs e)
        {
            txtval1.Clear();
            txtval2.Clear();
            txtval3.Clear();
        }

        private void btnsai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }
    }
}
