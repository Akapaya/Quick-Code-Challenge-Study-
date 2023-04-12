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
    public partial class frmIRPF : Form
    {
        public frmIRPF()
        {
            InitializeComponent();
        }

        private void btnPadrao_Click(object sender, EventArgs e)
        {
            Funcionario Padrao = new Funcionario();
            txtNome.Text = Padrao.Nome;
            txtIdade.Text = Padrao.Idade.ToString();
            txtSexo.Text = Padrao.Sexo.ToString();
            txtQtdHoras.Text = Padrao.QtHoras.ToString();
            txtvValorHora.Text = Padrao.ValorHora.ToString("c");
            lblImpRetido.Text = Padrao.ImpostoRetido.ToString("c");
            lblSalBruto.Text = Padrao.SalarioBruto.ToString("c");
            lblSalLiquido.Text = Padrao.SalarioLiquido.ToString("c");          
        }

        private void btnInformado_Click(object sender, EventArgs e)
        {
            frmIRPFInformado inf = new frmIRPFInformado();
            inf.ShowDialog();
        
        }
    }
}
