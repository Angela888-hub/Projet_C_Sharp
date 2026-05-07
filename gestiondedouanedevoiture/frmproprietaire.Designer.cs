
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
            this.lblrecherche = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.dgvProprietaires = new System.Windows.Forms.DataGridView();
            this.imageretour = new System.Windows.Forms.ImageList(this.components);
            this.btnretour = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.txtnif = new System.Windows.Forms.TextBox();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnvider = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidproprietaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txtprenoms = new System.Windows.Forms.TextBox();
            this.txttelephone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietaires)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblgestion
            // 
            this.lblgestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblgestion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblgestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestion.Location = new System.Drawing.Point(0, 0);
            this.lblgestion.Name = "lblgestion";
            this.lblgestion.Size = new System.Drawing.Size(1384, 57);
            this.lblgestion.TabIndex = 0;
            this.lblgestion.Text = "                             GESTION DE DOUANE DE VOITURE";
            this.lblgestion.Click += new System.EventHandler(this.lblgestion_Click);
            // 
            // lblrecherche
            // 
            this.lblrecherche.AutoSize = true;
            this.lblrecherche.ImageList = this.imageList1;
            this.lblrecherche.Location = new System.Drawing.Point(1132, 314);
            this.lblrecherche.Name = "lblrecherche";
            this.lblrecherche.Size = new System.Drawing.Size(12, 17);
            this.lblrecherche.TabIndex = 21;
            this.lblrecherche.Text = " ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // dgvProprietaires
            // 
            this.dgvProprietaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProprietaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProprietaires.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProprietaires.Location = new System.Drawing.Point(0, 57);
            this.dgvProprietaires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProprietaires.Name = "dgvProprietaires";
            this.dgvProprietaires.ReadOnly = true;
            this.dgvProprietaires.RowHeadersWidth = 51;
            this.dgvProprietaires.RowTemplate.Height = 24;
            this.dgvProprietaires.Size = new System.Drawing.Size(1384, 611);
            this.dgvProprietaires.TabIndex = 16;
            this.dgvProprietaires.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProprietaires_CellContentClick);
            // 
            // imageretour
            // 
            this.imageretour.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageretour.ImageStream")));
            this.imageretour.TransparentColor = System.Drawing.Color.Transparent;
            this.imageretour.Images.SetKeyName(0, "fleche-gauche.png");
            this.imageretour.Images.SetKeyName(1, "fleche-gauche.png");
            // 
            // btnretour
            // 
            this.btnretour.ImageIndex = 1;
            this.btnretour.ImageList = this.imageretour;
            this.btnretour.Location = new System.Drawing.Point(50, 11);
            this.btnretour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(52, 38);
            this.btnretour.TabIndex = 22;
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnenregistrer);
            this.panel2.Controls.Add(this.btnajouter);
            this.panel2.Controls.Add(this.txtnif);
            this.panel2.Controls.Add(this.btnmodifier);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnvider);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnsupprimer);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtnom);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtidproprietaire);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtadresse);
            this.panel2.Controls.Add(this.txtprenoms);
            this.panel2.Controls.Add(this.txttelephone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 346);
            this.panel2.TabIndex = 23;
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.SeaGreen;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.Location = new System.Drawing.Point(1245, 234);
            this.btnenregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(115, 29);
            this.btnenregistrer.TabIndex = 42;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnenregistrer.UseVisualStyleBackColor = false;
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnajouter.Location = new System.Drawing.Point(1124, 82);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(115, 34);
            this.btnajouter.TabIndex = 37;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            // 
            // txtnif
            // 
            this.txtnif.BackColor = System.Drawing.Color.Gray;
            this.txtnif.Location = new System.Drawing.Point(543, 104);
            this.txtnif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnif.Multiline = true;
            this.txtnif.Name = "txtnif";
            this.txtnif.Size = new System.Drawing.Size(516, 32);
            this.txtnif.TabIndex = 35;
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnmodifier.Location = new System.Drawing.Point(1124, 120);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(115, 34);
            this.btnmodifier.TabIndex = 38;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "PROPRIETAIRE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Id_Proprietaire:\r\n";
            // 
            // btnvider
            // 
            this.btnvider.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnvider.Location = new System.Drawing.Point(1124, 158);
            this.btnvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvider.Name = "btnvider";
            this.btnvider.Size = new System.Drawing.Size(115, 34);
            this.btnvider.TabIndex = 39;
            this.btnvider.Text = "Vider";
            this.btnvider.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Adresse:";
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.Crimson;
            this.btnsupprimer.Location = new System.Drawing.Point(1124, 196);
            this.btnsupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(115, 34);
            this.btnsupprimer.TabIndex = 40;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Telephone:";
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.Color.Gray;
            this.txtnom.Location = new System.Drawing.Point(543, 5);
            this.txtnom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(516, 32);
            this.txtnom.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nif_Cin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prénoms:";
            // 
            // txtidproprietaire
            // 
            this.txtidproprietaire.BackColor = System.Drawing.Color.LightGray;
            this.txtidproprietaire.Enabled = false;
            this.txtidproprietaire.Location = new System.Drawing.Point(543, 238);
            this.txtidproprietaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidproprietaire.Multiline = true;
            this.txtidproprietaire.Name = "txtidproprietaire";
            this.txtidproprietaire.ReadOnly = true;
            this.txtidproprietaire.Size = new System.Drawing.Size(516, 32);
            this.txtidproprietaire.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nom:";
            // 
            // txtadresse
            // 
            this.txtadresse.BackColor = System.Drawing.Color.Gray;
            this.txtadresse.Location = new System.Drawing.Point(543, 196);
            this.txtadresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtadresse.Multiline = true;
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(516, 32);
            this.txtadresse.TabIndex = 33;
            // 
            // txtprenoms
            // 
            this.txtprenoms.BackColor = System.Drawing.Color.Gray;
            this.txtprenoms.Location = new System.Drawing.Point(543, 57);
            this.txtprenoms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprenoms.Multiline = true;
            this.txtprenoms.Name = "txtprenoms";
            this.txtprenoms.Size = new System.Drawing.Size(516, 32);
            this.txtprenoms.TabIndex = 36;
            // 
            // txttelephone
            // 
            this.txttelephone.BackColor = System.Drawing.Color.Gray;
            this.txttelephone.Location = new System.Drawing.Point(543, 148);
            this.txttelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttelephone.Multiline = true;
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(516, 32);
            this.txttelephone.TabIndex = 34;
            // 
            // frmproprietaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.dgvProprietaires);
            this.Controls.Add(this.lblrecherche);
            this.Controls.Add(this.lblgestion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmproprietaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmproprietaire";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietaires)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgestion;
        private System.Windows.Forms.Label lblrecherche;
        private System.Windows.Forms.ImageList imageList1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridView dgvProprietaires;
        private System.Windows.Forms.ImageList imageretour;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.TextBox txtnif;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnvider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidproprietaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txtprenoms;
        private System.Windows.Forms.TextBox txttelephone;
    }
}