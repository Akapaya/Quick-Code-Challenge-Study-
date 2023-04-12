using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjEquacaoSegGrau
{
    public partial class frmEquacaoSegGrau : Form
    {
        #region Inicialização dos componentes
        public frmEquacaoSegGrau()
        {
            InitializeComponent();
        }
        #endregion

        #region Declaração de variáveis global
        double a, b, c, x1, x2, delta;int caso;
        #endregion

        #region Calcular usando Switch...Case
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    a = double.Parse(txtValorA.Text);
            //    if (a == 0)
            //    {
            //        MessageBox.Show("Valor de A não pode ser zero");
            //        return;
            //    }
            //    b = double.Parse(txtValorB.Text);
            //    c = double.Parse(txtValorC.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Inválido");
            //    LimpaTudo();
            //    return;
            //}
            //delta = Math.Pow(b, 2) - 4 * a * c;
            //lblDelta.Text = delta.ToString();
            //if (delta < 0)
            //{
            //    lblX11.Text = "X²"; lblX1.Text = "X";
            //    lblX22.Text = "X²"; lblX2.Text = "X";
            //    if (a < 0)
            //        this.pictureBox1.Image = global::prjEquacaoSegGrau.Properties.Resources.DME0AME0;
            //    else
            //        this.pictureBox1.Image = global::prjEquacaoSegGrau.Properties.Resources.DME0AMA0;
            //}
            //else
            //{
            //    if (delta == 0)
            //    {
            //        x1 = -b / 2 * a;
            //        lblX11.Text = x1.ToString("f3") + "²";
            //        lblX1.Text = x1.ToString("f3");
            //        lblX22.Text = x1.ToString("f3") + "²";
            //        lblX2.Text = x1.ToString("f3");
            //        if (a < 0)
            //            this.pictureBox1.Image = global::prjEquacaoSegGrau.Properties.Resources.D0AME0;
            //        else
            //            this.pictureBox1.Image = global::prjEquacaoSegGrau.Properties.Resources.D0AMA0;
            //    }
            //    else
            //    {
            //        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            //        lblX11.Text = x1.ToString("f3") + "²";
            //        lblX1.Text = x1.ToString("f3");
            //        lblX22.Text = x2.ToString("f3") + "²";
            //        lblX2.Text = x2.ToString("f3");
            //        if (a < 0)
            //            this.pictureBox1.Image = global::prjEquacaoSegGrau.Properties.Resources.DMA0AME0;
            //        else
            //            this.pictureBox1.Image = global::prjEquacaoSegGrau.Properties.Resources.DMA0AMA0;
            //    }
            //}
            try
            {
                a = double.Parse(txtValorA.Text);
                if (a == 0)
                {
                    MessageBox.Show("Valor de A não pode ser zero");
                    return;
                }
                b = double.Parse(txtValorB.Text);
                c = double.Parse(txtValorC.Text);
            }
            catch
            {
                MessageBox.Show("Inválido");
                LimpaTudo();
                return;
            }
            delta = Math.Pow(b, 2) - (4 * a * c); 
            if (delta == 0) caso = 0;
            if (delta > 0) caso = 1;
            if (delta < 0) caso = -1;
            lblDelta.Text = delta.ToString();
            switch (caso)
            {
                case 1:
                    maiorquezero();
                    break;
                case 0:
                    igualazero();
                    break;
                case -1:
                    menorquezero();
                    break;
                    

            }
        }
        #endregion

        #region Método Delta Menor que Zero
        public void menorquezero()
        {
            lblX11.Text = "X²"; lblX1.Text = "X";
            lblX22.Text = "X²"; lblX2.Text = "X";
            if (a < 0)
                pcbGrafico.Image = Properties.Resources.DME0AME0;
            else
                pcbGrafico.Image = Properties.Resources.DME0AMA0;
        }
        #endregion

        #region Método Delta Maior que Zero
        public void maiorquezero()
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            lblX11.Text = x1.ToString("f3") + "²";
            lblX1.Text = x1.ToString("f3");
            lblX22.Text = x2.ToString("f3") + "²";
            lblX2.Text = x2.ToString("f3");
            if (a < 0)
                pcbGrafico.Image = Properties.Resources.DMA0AME0;
            else
                pcbGrafico.Image = Properties.Resources.DMA0AMA0;
        }
        #endregion

        #region Método Delta Igual a Zero
        public void igualazero()
        {
            x1 = ( -b ) / ( 2 * a );
            lblX11.Text = x1.ToString("f3") + "²";
            lblX1.Text = x1.ToString("f3");
            lblX22.Text = x1.ToString("f3") + "²";
            lblX2.Text = x1.ToString("f3");
            if (a < 0)
                this.pcbGrafico.Image = global::prjEquacaoSegGrau.Properties.Resources.D0AME0;
            else
                this.pcbGrafico.Image = global::prjEquacaoSegGrau.Properties.Resources.D0AMA0;
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTudo();
        }
        #endregion

        #region Método Limpar Tudo
        private void LimpaTudo()
        {
            txtValorA.Clear(); lblA1.Text = "A"; lblA2.Text = "A"; lblFa.Text = "A"; lblFa2.Text = "A";
            txtValorB.Clear(); lblB1.Text = "B"; lblB2.Text = "B"; lblFb.Text = "B"; lblFb2.Text = "B²";
            txtValorC.Clear(); lblC1.Text = "C"; lblC2.Text = "C"; lblFc.Text = "C";
            lblX11.Text = "X²"; lblX1.Text = "X";
            lblX22.Text = "X²"; lblX2.Text = "X";
            lblDB2.Text = "B²"; lblDA.Text = "A"; lblDC.Text = "C";
            lblDelta.Text = "0";
            this.pcbGrafico.Image = null;
            txtValorA.Focus();
        }
        #endregion

        #region Fechar o Form
        private void frmEquacaoSegGrau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sair.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
            txtValorA.Focus();
        }
        #endregion

        #region Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Change da caixa A
        private void txtValorA_TextChanged(object sender, EventArgs e)
        {
            lblA1.Text = txtValorA.Text;
            lblA2.Text = txtValorA.Text;
            lblDA.Text = txtValorA.Text;
            lblFa.Text = txtValorA.Text;
            lblFa2.Text = txtValorA.Text;
            btnCalcular.Enabled = TestaCampos();
        }
        #endregion

        #region Change da caixa B
        private void txtValorB_TextChanged(object sender, EventArgs e)
        {
            lblB1.Text = txtValorB.Text;
            lblB2.Text = txtValorB.Text;
            lblDB2.Text = txtValorB.Text + "²";
            lblFb.Text = txtValorB.Text;
            lblFb2.Text = txtValorB.Text + "²";
            btnCalcular.Enabled = TestaCampos();
        }
        #endregion

        #region Change da caixa C
        private void txtValorC_TextChanged(object sender, EventArgs e)
        {
            lblC1.Text = txtValorC.Text;
            lblC2.Text = txtValorC.Text;
            lblDC.Text = txtValorC.Text;
            lblFc.Text = txtValorC.Text;
            btnCalcular.Enabled = TestaCampos();
        }
        #endregion

        #region Form Load
        private void frmEquacaoSegGrau_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(448, 404);
            btnCalcular.Enabled = false;
            this.pcbGrafico.Image = null;
            this.KeyPreview = true;
        }
        #endregion

        #region Form KeyDown
        private void frmEquacaoSegGrau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
        #endregion

        #region Função Testar Campos
        Boolean TestaCampos()
        {
            if (txtValorA.Text.Length > 0 && txtValorB.Text.Length > 0 && txtValorC.Text.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Verificação da tecla digitada
        private static void TeclaDigitada(KeyPressEventArgs e)
        {
            //              BS                  ,                  -                48=0              57=9
            if (e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 45 && !(e.KeyChar > 47 && e.KeyChar < 58))
                //e.KeyChar = e.KeyChar;
            //else
                e.KeyChar = Convert.ToChar(0);
        }
        #endregion

        #region caixa A KeyPress
        private void txtValorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TeclaDigitada(e);
        }
        #endregion

        #region caixa B KeyPress
        private void txtValorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TeclaDigitada(e);
        }
        #endregion

        #region caixa C KeyPress
        private void txtValorC_KeyPress(object sender, KeyPressEventArgs e)
        {
            TeclaDigitada(e);
        }
        #endregion

        #region quando entrar na caixa A
        private void txtValorA_Enter(object sender, EventArgs e)
        {
            txtValorA.Text = string.Empty;
        }
        #endregion

        #region quando entrar na caixa B
        private void txtValorB_Enter(object sender, EventArgs e)
        {
            txtValorB.Text = string.Empty;
        }
        #endregion

        #region quando entrar na caixa C
        private void txtValorC_Enter(object sender, EventArgs e)
        {
            txtValorC.Text = string.Empty;
        }
        #endregion

        #region Clique no Form
        private void frmEquacaoSegGrau_Click(object sender, EventArgs e)
        {
            
            if(this.ClientSize == new System.Drawing.Size(448, 404))
                this.ClientSize = new System.Drawing.Size(448, 548);
            else
                this.ClientSize = new System.Drawing.Size(448, 404);

        }
        #endregion


    }
}
