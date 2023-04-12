using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjIMC_31927
{
    public partial class Form1 : Form
    {
        double res;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttCalc_Click(object sender, EventArgs e)
        {
            PrjIMC_31927.clsIMC imc = new PrjIMC_31927.clsIMC();
            try
            {
                imc.peso = double.Parse(txtPes.Text);
                imc.altura = double.Parse(txtAlt.Text);
            }
            catch
            {
                Console.Write("Digite somente numeros");
                return;
            }    
            txtImc.Text = imc.imcS(double.Parse(txtAlt.Text), double.Parse(txtPes.Text));
            res = double.Parse(imc.imcS(double.Parse(txtAlt.Text), double.Parse(txtPes.Text)));
            if (RadbttM.Checked == true)
            {
                if (res < 20)
                {
                    lblres.Text = ("Abaixo do peso");
                }
                else
                {
                    if (res >= 25)
                    {
                        lblres.Text = ("Acima do peso");
                    }
                    else
                    {
                        lblres.Text = ("Peso ideal");
                    }
                }
            }
            if (RadbttF.Checked == true)
            {
                if (res < 19)
                {
                    lblres.Text = ("Abaixo do peso");
                }
                else
                {
                    if (res >= 24)
                    {
                        lblres.Text = ("Acima do peso");
                    }
                    else
                    {
                        lblres.Text = ("Peso ideal");
                    }
                }
            }
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            txtAlt.Clear();
            txtPes.Clear();
            txtImc.Clear();
            lblres.Text = "";
        }

        private void BttSai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sair", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
