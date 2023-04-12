using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjPCOII_1
{
    public partial class frmPCOII_1 : Form
    {
        public frmPCOII_1()
        {
            InitializeComponent();
        }
        clsRetangulo.Retangulo r = new clsRetangulo.Retangulo();
        private void frmPCOII_1_Load(object sender, EventArgs e)
        {
           
            if (txtAltura.Text == string.Empty & txtLargura.Text == string.Empty)
            {
                //Retangulo r = new Retangulo(2);
                //Retangulo r = new Retangulo(2,7);
                lblAltura.Text = r.altura.ToString();
                lblLargura.Text = r.largura.ToString();
                lblArea.Text = r.area.ToString();
                lblPerimetro.Text = r.perimetro.ToString();
                if (r.quadrado() == true)
                    lblRetQua.Text = "Sim";
                else
                    lblRetQua.Text = "Não";
            }
        }

        private void btnInformado_Click(object sender, EventArgs e)
        {
            try
            {
                r.altura = int.Parse(txtAltura.Text);
                r.largura = int.Parse(txtLargura.Text);
            }
            catch
            {
                MessageBox.Show("Erro nos dados informados!");
                return;
            }
            lblAltura.Text = r.altura.ToString();
            lblLargura.Text = r.largura.ToString();
            lblArea.Text = r.area.ToString();
            lblPerimetro.Text = r.perimetro.ToString();
            if (r.quadrado() == true)
                lblRetQua.Text = "Sim";
            else
                lblRetQua.Text = "Não";
        }
    }
}
