using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjAcad
{
    public partial class frmAcad : Form
    {
        public frmAcad()
        {
            InitializeComponent();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {     
            if (lstModalidades.SelectedIndex != -1)
            {
                lstEscolhidos.Items.Add(lstModalidades.SelectedItem);
                btnExcluir.Enabled = true;
                lstModalidades.Items.Remove(lstModalidades.SelectedItem);
                if (lstModalidades.Items.Count == 0)
                    btnIncluir.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecione uma modalidade \n para poder Incluir");
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        { 
            if (lstEscolhidos.SelectedIndex != -1)
            {
                lstModalidades.Items.Add(lstEscolhidos.SelectedItem);
                btnIncluir.Enabled = true;
                lstEscolhidos.Items.Remove(lstEscolhidos.SelectedItem);
                if (lstEscolhidos.Items.Count == 0)
                    btnExcluir.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecione uma modalidade \n para poder Excluir");
            }
        }
        private void frmXXXXXX_Load(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
            btnExcluir.Enabled = false;
            rdbManha.Checked = true;
            this.KeyPreview = true;
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {   
            double mensalidade;
            double valorModalidade;
            int dias = 0;

            if (chkSegunda.Checked == false && chkTerca.Checked == false && chkQuarta.Checked == false && chkQuinta.Checked == false && chkSexta.Checked == false && chkSabado.Checked == false)
            {
                MessageBox.Show("Escolha pelo menos um dos dias para efetuar o cálculo.");
                return;
            }

            if (chkSegunda.Checked)
                dias += 1;
            if (chkTerca.Checked)
                dias += 1;
            if (chkQuarta.Checked)
                dias += 1;
            if (chkQuinta.Checked)
                dias += 1;
            if (chkSexta.Checked)
                dias += 1;
            if (chkSabado.Checked)
                dias += 1;
            
            if (dias > 2)
            {
                valorModalidade = 30;
            }
            else
            {
                valorModalidade = 20;
            }
            mensalidade = valorModalidade * (lstEscolhidos.Items.Count);
            if (rdbTarde.Checked)
            {
                mensalidade = mensalidade * 0.90;
            }
            if (rdbNoite.Checked)
            {
                mensalidade = mensalidade * 0.85;
            }
            txtMensalidade.Text = mensalidade.ToString("C");
        }
       

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == string.Empty || textBox1.Text == string.Empty )
                btnCalcular.Enabled = false ;
            else
                btnCalcular.Enabled = true;
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            lblqtd.Text = checkedListBox1.CheckedItems.Count.ToString();
        }

        private void frmAcad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) // se a tecla pressionada for Return (Enter) selecione o próximo controle
            {
                SelectNextControl(this.ActiveControl, true, true, true, true); // para frente, apenas tabulação, aninhada, envolver
            }
                
        }

        private void frmAcad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sair", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }   
    }
}