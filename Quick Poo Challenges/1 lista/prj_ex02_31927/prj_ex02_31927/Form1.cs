using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_ex02_31927
{
    public partial class frm_ex01_31927 : Form
    {
        public frm_ex01_31927()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1, res;

            try
            {
                val1 = int.Parse(txtval1.Text);

                res = val1 * val1;
            }
            catch
            {
                MessageBox.Show("Somente números");
                txtval1.Text = "";
                return;
            }

            txtres.Text = res.ToString();
        }
    }
}
