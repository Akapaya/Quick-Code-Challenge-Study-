using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex10_31927
{
    public partial class frm_ex10_31927 : Form
    {
        public frm_ex10_31927()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1, val2;
            try
            {

                val1 = double.Parse(txtval1.Text);
            }
            catch
            {
                MessageBox.Show("Somente números");
                txtval1.Text = "";
                txtval2.Text = "";
                return;
            }
            val2 = (9 / 5) * (val1 + 32);

            txtval2.Text = val2.ToString();
        }
    }
}
