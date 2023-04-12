using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex06_31927
{
    public partial class frm_ex06_31927 : Form
    {
        public frm_ex06_31927()
        {
            InitializeComponent();
        }

        private void frm_ex06_31927_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1, val2, val3, val4, res;
            try
            {
                val1 = int.Parse(txtval1.Text);
                val2 = int.Parse(txtval2.Text);
                val3 = int.Parse(txtval3.Text);
                val4 = int.Parse(txtval4.Text);
            }

            catch
            {
                MessageBox.Show("Somente números");
                txtval1.Text = "";
                txtval2.Text = "";
                txtval3.Text = "";
                txtval4.Text = "";
                return;
            }
            res = (val1 + val2 + val3 + val4) / 4;

            txtres.Text = res.ToString();
        }
    }
}
