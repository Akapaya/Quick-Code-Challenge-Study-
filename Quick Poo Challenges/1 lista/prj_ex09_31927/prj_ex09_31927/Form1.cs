using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex09_31927
{
    public partial class frm_ex09_31927 : Form
    {
        public frm_ex09_31927()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1, val2, val3;
            try
            {

                val1 = int.Parse(txtval1.Text);
                val2 = int.Parse(txtval2.Text);

            }
            catch
            {
                MessageBox.Show("Somente números");
                txtval1.Text = "";
                txtval2.Text = "";
                return;
            }
            val3 = val1 * val2;

            txtval3.Text = val3.ToString();
        }
    }
}
