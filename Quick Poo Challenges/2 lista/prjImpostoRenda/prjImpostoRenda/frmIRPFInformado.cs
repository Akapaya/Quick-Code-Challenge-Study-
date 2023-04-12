using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjImpostoRenda
{
    public partial class frmIRPFInformado : Form
    {
        public frmIRPFInformado()
        {
            InitializeComponent();
        }

        private void btnInformado_Click(object sender, EventArgs e)
        {
            int idade;
            string nome;
            char sexo;
            double qtdhoras;
            double valorhora;

            Funcionario Info = new Funcionario();
            
            try
            {
                valorhora = double.Parse(txtValHoraInf.Text);
                Info.ValorHora = valorhora;
                if (txtReajustaValor.Text == string.Empty)
                {
                    valorhora = double.Parse(txtValHoraInf.Text);
                }
                else
                {
                    valorhora = Info.ReajustarValorHora(double.Parse(txtReajustaValor.Text));
                }
                Info.ValorHora = valorhora;
                idade = int.Parse(txtIdadeInf.Text);
                nome = txtNomeInf.Text;
                sexo = char.Parse(txtSexoInf.Text);
                qtdhoras = double.Parse(txtQtdHorasInf.Text);
               

            }
            catch
            {
                this.Text = "Favor Informar os Valores corretamente!";
                
                return;
            }


            Info.Nome = nome;
            Info.Idade = idade;
            Info.Sexo = sexo;
            Info.QtHoras = qtdhoras;



            lblInfImpRet.Text = Info.ImpostoRetido.ToString("c");
            lblInfSalBruto.Text = Info.SalarioBruto.ToString("c");
            lblInfSalLiq.Text = Info.SalarioLiquido.ToString("c");
            this.Text = txtNomeInf.Text;
            lblInfNome.Text = Info.Nome;
            lblInfIdade.Text = Info.Idade.ToString();
            lblInfQtdHoras.Text = Info.QtHoras.ToString();
            lblInfSexo.Text = Info.Sexo.ToString();
            lblInfValorHora.Text = Info.ValorHora.ToString();

           
           
        }

        private void frmIRPFInformado_Load(object sender, EventArgs e)
        {
            this.Text = "Aula Classe";
        }

        private void txtNomeInf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
