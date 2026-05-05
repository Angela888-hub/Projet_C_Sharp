
namespace gestiondedouanedevoiture
{
    partial class frmproprietaire
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproprietaire));
            this.lblgestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtidproprietaire = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.txtnif = new System.Windows.Forms.TextBox();
            this.txtprenoms = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.dgvProprietaires = new System.Windows.Forms.DataGridView();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnvider = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblrecherche = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnretour = new System.Windows.Forms.Button();
            this.imageretour = new System.Windows.Forms.ImageList(this.components);
            this.btnsuivant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietaires)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblgestion
            // 
            this.lblgestion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblgestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestion.Location = new System.Drawing.Point(287, 6);
            this.lblgestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgestion.Name = "lblgestion";
            this.lblgestion.Size = new System.Drawing.Size(539, 46);
            this.lblgestion.TabIndex = 0;
            this.lblgestion.Text = "GESTION DE DOUANE DE VOITURE";
            this.lblgestion.Click += new System.EventHandler(this.lblgestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROPRIETAIRE";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prénoms:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nif_Cin:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telephone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Adresse:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Id_Proprietaire:\r\n";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.Color.Gray;
            this.txtnom.Location = new System.Drawing.Point(308, 54);
            this.txtnom.Margin = new System.Windows.Forms.Padding(2);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(388, 27);
            this.txtnom.TabIndex = 9;
            // 
            // txtidproprietaire
            // 
            this.txtidproprietaire.BackColor = System.Drawing.Color.LightGray;
            this.txtidproprietaire.Enabled = false;
            this.txtidproprietaire.Location = new System.Drawing.Point(308, 243);
            this.txtidproprietaire.Margin = new System.Windows.Forms.Padding(2);
            this.txtidproprietaire.Multiline = true;
            this.txtidproprietaire.Name = "txtidproprietaire";
            this.txtidproprietaire.ReadOnly = true;
            this.txtidproprietaire.Size = new System.Drawing.Size(388, 27);
            this.txtidproprietaire.TabIndex = 10;
            // 
            // txtadresse
            // 
            this.txtadresse.BackColor = System.Drawing.Color.Gray;
            this.txtadresse.Location = new System.Drawing.Point(308, 209);
            this.txtadresse.Margin = new System.Windows.Forms.Padding(2);
            this.txtadresse.Multiline = true;
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(388, 27);
            this.txtadresse.TabIndex = 11;
            this.txtadresse.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txttelephone
            // 
            this.txttelephone.BackColor = System.Drawing.Color.Gray;
            this.txttelephone.Location = new System.Drawing.Point(308, 170);
            this.txttelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txttelephone.Multiline = true;
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(388, 27);
            this.txttelephone.TabIndex = 12;
            this.txttelephone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtnif
            // 
            this.txtnif.BackColor = System.Drawing.Color.Gray;
            this.txtnif.Location = new System.Drawing.Point(308, 134);
            this.txtnif.Margin = new System.Windows.Forms.Padding(2);
            this.txtnif.Multiline = true;
            this.txtnif.Name = "txtnif";
            this.txtnif.Size = new System.Drawing.Size(388, 27);
            this.txtnif.TabIndex = 13;
            this.txtnif.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtprenoms
            // 
            this.txtprenoms.BackColor = System.Drawing.Color.Gray;
            this.txtprenoms.Location = new System.Drawing.Point(308, 96);
            this.txtprenoms.Margin = new System.Windows.Forms.Padding(2);
            this.txtprenoms.Multiline = true;
            this.txtprenoms.Name = "txtprenoms";
            this.txtprenoms.Size = new System.Drawing.Size(388, 27);
            this.txtprenoms.TabIndex = 14;
            this.txtprenoms.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnajouter.Location = new System.Drawing.Point(2, 2);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(86, 28);
            this.btnajouter.TabIndex = 15;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // dgvProprietaires
            // 
            this.dgvProprietaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProprietaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProprietaires.Location = new System.Drawing.Point(0, 275);
            this.dgvProprietaires.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProprietaires.Name = "dgvProprietaires";
            this.dgvProprietaires.ReadOnly = true;
            this.dgvProprietaires.RowHeadersWidth = 51;
            this.dgvProprietaires.RowTemplate.Height = 24;
            this.dgvProprietaires.Size = new System.Drawing.Size(1005, 268);
            this.dgvProprietaires.TabIndex = 16;
            this.dgvProprietaires.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProprietaires_CellContentClick);
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnmodifier.Location = new System.Drawing.Point(2, 34);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(86, 28);
            this.btnmodifier.TabIndex = 17;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnvider
            // 
            this.btnvider.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnvider.Location = new System.Drawing.Point(2, 66);
            this.btnvider.Margin = new System.Windows.Forms.Padding(2);
            this.btnvider.Name = "btnvider";
            this.btnvider.Size = new System.Drawing.Size(86, 28);
            this.btnvider.TabIndex = 18;
            this.btnvider.Text = "Vider";
            this.btnvider.UseVisualStyleBackColor = false;
            this.btnvider.Click += new System.EventHandler(this.btnvider_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.Crimson;
            this.btnsupprimer.Location = new System.Drawing.Point(2, 98);
            this.btnsupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(86, 28);
            this.btnsupprimer.TabIndex = 19;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnajouter);
            this.flowLayoutPanel1.Controls.Add(this.btnmodifier);
            this.flowLayoutPanel1.Controls.Add(this.btnvider);
            this.flowLayoutPanel1.Controls.Add(this.btnsupprimer);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(726, 134);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(94, 128);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "label9";
            // 
            // lblrecherche
            // 
            this.lblrecherche.AutoSize = true;
            this.lblrecherche.ImageList = this.imageList1;
            this.lblrecherche.Location = new System.Drawing.Point(849, 255);
            this.lblrecherche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrecherche.Name = "lblrecherche";
            this.lblrecherche.Size = new System.Drawing.Size(10, 13);
            this.lblrecherche.TabIndex = 21;
            this.lblrecherche.Text = " ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // btnretour
            // 
            this.btnretour.ImageIndex = 1;
            this.btnretour.ImageList = this.imageretour;
            this.btnretour.Location = new System.Drawing.Point(14, 6);
            this.btnretour.Margin = new System.Windows.Forms.Padding(2);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(39, 31);
            this.btnretour.TabIndex = 22;
            this.btnretour.UseVisualStyleBackColor = true;
            // 
            // imageretour
            // 
            this.imageretour.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageretour.ImageStream")));
            this.imageretour.TransparentColor = System.Drawing.Color.Transparent;
            this.imageretour.Images.SetKeyName(0, "fleche-gauche.png");
            this.imageretour.Images.SetKeyName(1, "fleche-gauche.png");
            // 
            // btnsuivant
            // 
            this.btnsuivant.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsuivant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuivant.Location = new System.Drawing.Point(862, 240);
            this.btnsuivant.Margin = new System.Windows.Forms.Padding(2);
            this.btnsuivant.Name = "btnsuivant";
            this.btnsuivant.Size = new System.Drawing.Size(77, 24);
            this.btnsuivant.TabIndex = 23;
            this.btnsuivant.Text = "Suivant";
            this.btnsuivant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsuivant.UseVisualStyleBackColor = false;
            this.btnsuivant.Click += new System.EventHandler(this.btnsuivant_Click);
            // 
            // frmproprietaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 543);
            this.Controls.Add(this.btnsuivant);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvProprietaires);
            this.Controls.Add(this.txtprenoms);
            this.Controls.Add(this.txtnif);
            this.Controls.Add(this.txttelephone);
            this.Controls.Add(this.lblrecherche);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.txtidproprietaire);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblgestion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmproprietaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmproprietaire";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietaires)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtidproprietaire;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.TextBox txtnif;
        private System.Windows.Forms.TextBox txtprenoms;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.DataGridView dgvProprietaires;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnvider;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblrecherche;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.ImageList imageretour;
        private System.Windows.Forms.Button btnsuivant;
    }
}