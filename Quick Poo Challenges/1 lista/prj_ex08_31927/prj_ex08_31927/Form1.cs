using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex08_31927
{
    public partial class frm_ex08_31927 : Form
    {
        public frm_ex08_31927()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1, res;

            try
            {

                val1 = double.Parse(txtval.Text);

                res = (val1 * 1852) / 1000;
            }
            catch
            {
                MessageBox.Show("Somente números");
                txtval.Text = "";
                return;
            }

            txtres.Text = res.ToString();
        }
    }
}
