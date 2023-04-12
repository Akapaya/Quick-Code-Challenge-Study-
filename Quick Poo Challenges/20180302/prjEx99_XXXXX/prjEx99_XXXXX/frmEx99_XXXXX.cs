using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjEx99_XXXXX
{
    public partial class frmEx99_XXXXX : Form
    {
        public frmEx99_XXXXX()
        {
            InitializeComponent();
        }

        private void frmEx99_XXXXX_Load(object sender, EventArgs e)
        {
            rdbMasculino.Checked = true;
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            try
            {
                peso = double.Parse(txtPeso.Text);
                altura = double.Parse(txtAltura.Text);

            }
            catch
            {
                MessageBox.Show("Deu pau!");
                //txtAltura.Clear();
                //txtPeso.Clear();
                //txtIMC.Clear();
                //lblObservacao.Text = "";
                //txtPeso.Focus();
               
                //btnLimpar_Click(sender, e);

                Limpar();
                return;
            }
            imc = peso / Math.Pow(altura, 2);
            txtIMC.Text = imc.ToString("##.##");
            // txtIMC.Text = imc.ToString();

            if (rdbMasculino.Checked)
            {
                if (imc < 10.0)
                {
                    lblObservacao.Text = "Magro";
                }
                else
                {
                    if (imc > 30)
                    {
                        lblObservacao.Text = "Gordo";
                    }
                    else
                    {
                        lblObservacao.Text = "Normal";
                    }
                }
            }
            else
            {
                if (imc < 10.0)
                {
                    lblObservacao.Text = "Magra";
                }
                else
                {
                    if (imc > 30)
                    {
                        lblObservacao.Text = "Gorda";
                    }
                    else
                    {
                        lblObservacao.Text = "Fem Normal";
                    }
                }

            }




        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();

        }

        #region Meu metodo Limpar
        private void Limpar()
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
            lblObservacao.Text = "";
            txtPeso.Focus();
        }
        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Sair", "Fechar Aplicativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            Close();
        }

    }
}
