using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_d_une_bibliotheque
{
    public partial class Form3 : Form
    {
        

        public object DataGridView1 { get; private set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            
        }

        private void txt_cl1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
