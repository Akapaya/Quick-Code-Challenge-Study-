using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_31927
{
    public partial class frm_ex_31927 : Form
    {
        public frm_ex_31927()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1, val2;
            double val3, val4;

            

            if (cmblista.SelectedIndex == 0)
            {
                val1 = int.Parse(txtval1.Text);
                val2 = int.Parse(txtval2.Text);

                val3 = val1 * val2;
                val4 = 2 * (val1 + val2);
                lstb.Items.Add("O comprimento : " + val1);
                lstb.Items.Add("A largura : " + val2);
                lstb.Items.Add("A area : " + val3);
                lstb.Items.Add("O perimetro : " + val4);
                lstb.Items.Add("---------------------");
            }

            if (cmblista.SelectedIndex == 1)
            {
                val1 = int.Parse(txtval3.Text);
                val2 = int.Parse(txtval4.Text);
                val3 = (val1 * val2) / 2;
                lstb.Items.Add("A base : " + val1);
                lstb.Items.Add("A altura : " + val2);
                lstb.Items.Add("A area : " + val3);
                lstb.Items.Add("---------------------");
            }

            if (cmblista.SelectedIndex == 2)
            {
                val1 = int.Parse(txtval5.Text);
                val3 = Math.PI * (val1 * val1);
                val4 = 2 * Math.PI * val1;
                lstb.Items.Add("O raio : " + val1);
                lstb.Items.Add("A area : " + val3);
                lstb.Items.Add("O perimetro : " + val4);
                lstb.Items.Add("---------------------");
            }
        }

        private void cmblista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmblista.SelectedIndex == 0)
            {
                pcb1.BackgroundImage = Properties.Resources.retangulo;
                txtval1.Enabled = true;
                txtval2.Enabled = true;
                txtval3.Enabled = false;
                txtval4.Enabled = false;
                txtval5.Enabled = false;
            }
            else
            {
                if (cmblista.SelectedIndex == 1)
                {
                    pcb1.BackgroundImage = Properties.Resources.triangulo;
                    txtval1.Enabled = false;
                    txtval2.Enabled = false;
                    txtval3.Enabled = true;
                    txtval4.Enabled = true;
                    txtval5.Enabled = false;
                }
                else
                {
                    if (cmblista.SelectedIndex == 2)
                    {
                        pcb1.BackgroundImage = Properties.Resources.circulo;
                        txtval3.Enabled = false;
                        txtval4.Enabled = false;
                        txtval1.Enabled = false;
                        txtval2.Enabled = false;
                        txtval5.Enabled = true;
                    }

                    else
                    {
                        txtval3.Enabled = true;
                        txtval4.Enabled = true;
                        txtval1.Enabled = true;
                        txtval2.Enabled = true;
                        txtval5.Enabled = true;
                    }
                }

            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtval1.Clear();
            txtval2.Clear();
            txtval3.Clear();
            txtval4.Clear();
            txtval5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstb.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
