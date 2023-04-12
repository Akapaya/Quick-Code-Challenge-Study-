using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_Exemplo_Metodos
{
    public partial class frmMetodos : Form
    {
        public frmMetodos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtE1.Text.Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtS2.Text = txtE2.Text.Substring(4,6);
            //txtS2.Text = txtE2.Text.Substring(int.Parse(txtX.Text), int.Parse(txtY.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtS3.Text = txtE3.Text.Trim();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtS4.Text = txtE4.Text.Trim().Length.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtS5.Text = txtE5.Text.Replace(" ", "");
            //txtS5.Text = txtE5.Text.Replace(TXTX1.Text, TXTY1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtS6.Text = txtE6.Text.Insert(int.Parse(txtINT.Text),txtCHAR.Text);
        }

        private void frmMetodos_Load(object sender, EventArgs e)
        {
            chkAtivaDesativa.Checked = false;
            cmbSemana.Visible = false;
            cmbSemana.SelectedIndex = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //txtTextoInserido.Text = txtTexto.Text.PadLeft(10, '0');
            txtTextoInserido.Text = txtTexto.Text.PadLeft(int.Parse(txtTextoQtd.Text), char.Parse(txtOque.Text));

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtir.Text = txttextor.Text.PadRight(int.Parse(txtqtdr.Text), char.Parse(txtoquer.Text));
        }

        private void chkAtivaDesativa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivaDesativa.Checked==true)
            {
                cmbSemana.Visible = true;
                chkAtivaDesativa.Text = "Esconder";
            }
            else
            {
                cmbSemana.Visible = false;
                chkAtivaDesativa.Text = "Ver";
            }
        }

        private void cmbSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBLINDICE.Text = cmbSemana.SelectedIndex.ToString();
            LBLITEM.Text = cmbSemana.SelectedItem.ToString();
            LBLQTD.Text = cmbSemana.Items.Count.ToString();
        }

        private void frmMetodos_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string menssagem = "Deseja Sair?";
            const string titulo = "Fechando o Aplicativo";

            var resultado = MessageBox.Show(menssagem, titulo,
                                 MessageBoxButtons.YesNoCancel,
                                 MessageBoxIcon.Question);


            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (resultado == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    MessageBox.Show("Cancelando");
                    e.Cancel = true;
                    return;
                }
            }

        }
    }
}
