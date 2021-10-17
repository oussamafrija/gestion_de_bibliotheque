using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_d_une_bibliotheque
{
    public partial class Form4 : Form
    {
        public Form4(string code)
        {
            InitializeComponent();
            txt_code1.Text = code;
        }

        private void txt_cl_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
