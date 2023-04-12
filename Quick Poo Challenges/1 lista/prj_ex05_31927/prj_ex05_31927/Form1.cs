using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex05_31927
{
    public partial class frm_ex05_31927 : Form
    {
        public frm_ex05_31927()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1, res;

            double volume;

            try
            {

                val1 = double.Parse(txtval.Text);

                res = val1 / 2;

                volume = (4 * 3.1415926) * ((Math.Pow(res, 3)) / 3);

            }

            catch
            {
                MessageBox.Show("Somente números");
                txtval.Text = "";
                return;
            }
            txtres.Text = volume.ToString();
        }
    }
}
