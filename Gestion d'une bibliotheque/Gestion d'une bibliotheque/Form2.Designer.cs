
namespace Gestion_d_une_bibliotheque
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cl = new System.Windows.Forms.TextBox();
            this.txt_titre = new System.Windows.Forms.TextBox();
            this.txt_auteur = new System.Windows.Forms.TextBox();
            this.mtb_date = new System.Windows.Forms.MaskedTextBox();
            this.rb_dis = new System.Windows.Forms.RadioButton();
            this.rb_indis = new System.Windows.Forms.RadioButton();
            this.cb_categorie = new System.Windows.Forms.ComboBox();
            this.remiseblanc = new System.Windows.Forms.Button();
            this.ann = new System.Windows.Forms.Button();
            this.val = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Code_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilite_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_vider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(219, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un livre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code livre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Auteur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(47, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Disponibilite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(47, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categorie";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_cl
            // 
            this.txt_cl.Location = new System.Drawing.Point(270, 104);
            this.txt_cl.Name = "txt_cl";
            this.txt_cl.Size = new System.Drawing.Size(186, 23);
            this.txt_cl.TabIndex = 7;
            this.txt_cl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_titre
            // 
            this.txt_titre.Location = new System.Drawing.Point(270, 142);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(186, 23);
            this.txt_titre.TabIndex = 8;
            this.txt_titre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_auteur
            // 
            this.txt_auteur.Location = new System.Drawing.Point(270, 179);
            this.txt_auteur.Name = "txt_auteur";
            this.txt_auteur.Size = new System.Drawing.Size(186, 23);
            this.txt_auteur.TabIndex = 9;
            // 
            // mtb_date
            // 
            this.mtb_date.Location = new System.Drawing.Point(270, 212);
            this.mtb_date.Mask = "00/00/0000 90:00";
            this.mtb_date.Name = "mtb_date";
            this.mtb_date.Size = new System.Drawing.Size(186, 23);
            this.mtb_date.TabIndex = 10;
            // 
            // rb_dis
            // 
            this.rb_dis.AutoSize = true;
            this.rb_dis.BackColor = System.Drawing.Color.Silver;
            this.rb_dis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rb_dis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_dis.Location = new System.Drawing.Point(270, 252);
            this.rb_dis.Name = "rb_dis";
            this.rb_dis.Size = new System.Drawing.Size(83, 19);
            this.rb_dis.TabIndex = 11;
            this.rb_dis.TabStop = true;
            this.rb_dis.Text = "Disponible";
            this.rb_dis.UseVisualStyleBackColor = false;
            // 
            // rb_indis
            // 
            this.rb_indis.AutoSize = true;
            this.rb_indis.BackColor = System.Drawing.Color.Silver;
            this.rb_indis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rb_indis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_indis.Location = new System.Drawing.Point(385, 252);
            this.rb_indis.Name = "rb_indis";
            this.rb_indis.Size = new System.Drawing.Size(92, 19);
            this.rb_indis.TabIndex = 12;
            this.rb_indis.TabStop = true;
            this.rb_indis.Text = "Indisponible";
            this.rb_indis.UseVisualStyleBackColor = false;
            // 
            // cb_categorie
            // 
            this.cb_categorie.FormattingEnabled = true;
            this.cb_categorie.Items.AddRange(new object[] {
            "...",
            "Science",
            "Comique",
            "Geographie",
            "Islamique",
            "Autre..."});
            this.cb_categorie.Location = new System.Drawing.Point(270, 296);
            this.cb_categorie.Name = "cb_categorie";
            this.cb_categorie.Size = new System.Drawing.Size(186, 23);
            this.cb_categorie.TabIndex = 13;
            // 
            // remiseblanc
            // 
            this.remiseblanc.BackColor = System.Drawing.SystemColors.Highlight;
            this.remiseblanc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remiseblanc.Location = new System.Drawing.Point(52, 349);
            this.remiseblanc.Name = "remiseblanc";
            this.remiseblanc.Size = new System.Drawing.Size(128, 34);
            this.remiseblanc.TabIndex = 14;
            this.remiseblanc.Text = "Remise blanc";
            this.remiseblanc.UseVisualStyleBackColor = false;
            this.remiseblanc.Click += new System.EventHandler(this.button1_Click);
            // 
            // ann
            // 
            this.ann.BackColor = System.Drawing.SystemColors.Highlight;
            this.ann.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ann.Location = new System.Drawing.Point(586, 349);
            this.ann.Name = "ann";
            this.ann.Size = new System.Drawing.Size(75, 35);
            this.ann.TabIndex = 15;
            this.ann.Text = "Annuler";
            this.ann.UseVisualStyleBackColor = false;
            this.ann.Click += new System.EventHandler(this.ann_Click);
            // 
            // val
            // 
            this.val.BackColor = System.Drawing.SystemColors.Highlight;
            this.val.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.val.Location = new System.Drawing.Point(518, 288);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(75, 35);
            this.val.TabIndex = 16;
            this.val.Text = "Valider";
            this.val.UseVisualStyleBackColor = false;
            this.val.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_livre,
            this.titre_livre,
            this.Auteur_livre,
            this.date_livre,
            this.disponibilite_livre,
            this.Categorie_livre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(640, 115);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Code_livre
            // 
            this.Code_livre.HeaderText = "Code";
            this.Code_livre.Name = "Code_livre";
            this.Code_livre.ReadOnly = true;
            // 
            // titre_livre
            // 
            this.titre_livre.HeaderText = "Titre";
            this.titre_livre.Name = "titre_livre";
            this.titre_livre.ReadOnly = true;
            // 
            // Auteur_livre
            // 
            this.Auteur_livre.HeaderText = "Auteur";
            this.Auteur_livre.Name = "Auteur_livre";
            this.Auteur_livre.ReadOnly = true;
            // 
            // date_livre
            // 
            this.date_livre.HeaderText = "Date";
            this.date_livre.Name = "date_livre";
            this.date_livre.ReadOnly = true;
            // 
            // disponibilite_livre
            // 
            this.disponibilite_livre.HeaderText = "Disponibilite";
            this.disponibilite_livre.Name = "disponibilite_livre";
            this.disponibilite_livre.ReadOnly = true;
            // 
            // Categorie_livre
            // 
            this.Categorie_livre.HeaderText = "Categorie";
            this.Categorie_livre.Name = "Categorie_livre";
            this.Categorie_livre.ReadOnly = true;
            // 
            // bt_vider
            // 
            this.bt_vider.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_vider.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_vider.Location = new System.Drawing.Point(454, 349);
            this.bt_vider.Name = "bt_vider";
            this.bt_vider.Size = new System.Drawing.Size(75, 35);
            this.bt_vider.TabIndex = 18;
            this.bt_vider.Text = "Effacer";
            this.bt_vider.UseVisualStyleBackColor = false;
            this.bt_vider.Click += new System.EventHandler(this.bt_vider_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(689, 541);
            this.Controls.Add(this.bt_vider);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.val);
            this.Controls.Add(this.ann);
            this.Controls.Add(this.remiseblanc);
            this.Controls.Add(this.cb_categorie);
            this.Controls.Add(this.rb_indis);
            this.Controls.Add(this.rb_dis);
            this.Controls.Add(this.mtb_date);
            this.Controls.Add(this.txt_auteur);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.txt_cl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Ajouter";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cl;
        private System.Windows.Forms.TextBox txt_titre;
        private System.Windows.Forms.TextBox txt_auteur;
        private System.Windows.Forms.MaskedTextBox mtb_date;
        private System.Windows.Forms.RadioButton rb_dis;
        private System.Windows.Forms.RadioButton rb_indis;
        private System.Windows.Forms.ComboBox cb_categorie;
        private System.Windows.Forms.Button remiseblanc;
        private System.Windows.Forms.Button ann;
        private System.Windows.Forms.Button val;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilite_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie_livre;
        private System.Windows.Forms.Button bt_vider;
    }
}