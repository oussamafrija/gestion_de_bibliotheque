using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_d_une_bibliotheque
{
    public partial class Form2 : Form
    {

        List<eleve> E = new List<eleve>();
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = -1;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                s = row.Index;

            if (s!=-1)
            {
                dataGridView1.Rows.RemoveAt(s);
            }
            else
            {
                MessageBox.Show("Selectionnez une ligne !", "Error", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)

        {
            eleve ele = new eleve();
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = txt_cl.Text;
            dataGridView1.Rows[n].Cells[1].Value = txt_titre.Text;
            dataGridView1.Rows[n].Cells[2].Value = txt_auteur.Text;
            dataGridView1.Rows[n].Cells[3].Value = mtb_date.Text;
            if (rb_dis.Checked == true)
            {
                dataGridView1.Rows[n].Cells[4].Value = "disponible";
            }
            else
            {
                dataGridView1.Rows[n].Cells[4].Value = "indisponible";
            }
            dataGridView1.Rows[n].Cells[5].Value = cb_categorie.Text;

            MessageBox.Show("Votre livre a ete bien ajoutee", "Bien ajoutee", MessageBoxButtons.OK, MessageBoxIcon.Information);

            E.Add(ele);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ann_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            


        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            txt_cl.Clear();
            txt_titre.Clear();
            txt_auteur.Clear();
            mtb_date.Clear();
            rb_dis.Checked = false;
            rb_indis.Checked = false;
            cb_categorie.SelectedIndex = 0;
        }
    }
}
