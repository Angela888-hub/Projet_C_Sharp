
namespace gestiondedouanedevoiture
{
    partial class frmdeclarationvoiture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdeclarationvoiture));
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboModeproprietaire = new System.Windows.Forms.ComboBox();
            this.txtvaleur = new System.Windows.Forms.TextBox();
            this.txtannee = new System.Windows.Forms.TextBox();
            this.txtmodele = new System.Windows.Forms.TextBox();
            this.txtmarque = new System.Windows.Forms.TextBox();
            this.txtvin = new System.Windows.Forms.TextBox();
            this.lblvin = new System.Windows.Forms.Label();
            this.lblmarque = new System.Windows.Forms.Label();
            this.lblmodele = new System.Windows.Forms.Label();
            this.lblproprietaire = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnvider = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.dgvDeclarations = new System.Windows.Forms.DataGridView();
            this.grpdeclaration = new System.Windows.Forms.GroupBox();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.txtdatedecl = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblrep = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnretour = new System.Windows.Forms.Button();
            this.imageretour = new System.Windows.Forms.ImageList(this.components);
            this.btnsuivant = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeclarations)).BeginInit();
            this.grpdeclaration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(134, 10);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(602, 37);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = " GESTION DE DOUANE DE VOITURE";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROPRIETES DE LA VOITURE\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboModeproprietaire);
            this.panel2.Controls.Add(this.txtvaleur);
            this.panel2.Controls.Add(this.txtannee);
            this.panel2.Controls.Add(this.txtmodele);
            this.panel2.Controls.Add(this.txtmarque);
            this.panel2.Controls.Add(this.txtvin);
            this.panel2.Location = new System.Drawing.Point(442, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 182);
            this.panel2.TabIndex = 9;
            // 
            // comboModeproprietaire
            // 
            this.comboModeproprietaire.FormattingEnabled = true;
            this.comboModeproprietaire.Location = new System.Drawing.Point(20, 155);
            this.comboModeproprietaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboModeproprietaire.Name = "comboModeproprietaire";
            this.comboModeproprietaire.Size = new System.Drawing.Size(278, 21);
            this.comboModeproprietaire.TabIndex = 13;
            // 
            // txtvaleur
            // 
            this.txtvaleur.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtvaleur.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtvaleur.Location = new System.Drawing.Point(20, 124);
            this.txtvaleur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtvaleur.Multiline = true;
            this.txtvaleur.Name = "txtvaleur";
            this.txtvaleur.Size = new System.Drawing.Size(278, 28);
            this.txtvaleur.TabIndex = 12;
            // 
            // txtannee
            // 
            this.txtannee.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtannee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtannee.Location = new System.Drawing.Point(20, 94);
            this.txtannee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtannee.Multiline = true;
            this.txtannee.Name = "txtannee";
            this.txtannee.Size = new System.Drawing.Size(278, 28);
            this.txtannee.TabIndex = 11;
            this.txtannee.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtmodele
            // 
            this.txtmodele.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtmodele.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtmodele.Location = new System.Drawing.Point(20, 65);
            this.txtmodele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmodele.Multiline = true;
            this.txtmodele.Name = "txtmodele";
            this.txtmodele.Size = new System.Drawing.Size(278, 28);
            this.txtmodele.TabIndex = 10;
            // 
            // txtmarque
            // 
            this.txtmarque.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtmarque.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtmarque.Location = new System.Drawing.Point(20, 36);
            this.txtmarque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmarque.Multiline = true;
            this.txtmarque.Name = "txtmarque";
            this.txtmarque.Size = new System.Drawing.Size(278, 28);
            this.txtmarque.TabIndex = 9;
            this.txtmarque.TextChanged += new System.EventHandler(this.txtmarque_TextChanged);
            // 
            // txtvin
            // 
            this.txtvin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtvin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtvin.Location = new System.Drawing.Point(20, 6);
            this.txtvin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtvin.Multiline = true;
            this.txtvin.Name = "txtvin";
            this.txtvin.Size = new System.Drawing.Size(278, 28);
            this.txtvin.TabIndex = 8;
            // 
            // lblvin
            // 
            this.lblvin.AutoSize = true;
            this.lblvin.Location = new System.Drawing.Point(298, 11);
            this.lblvin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvin.Name = "lblvin";
            this.lblvin.Size = new System.Drawing.Size(106, 13);
            this.lblvin.TabIndex = 10;
            this.lblvin.Text = "vin_numero_chassis:\r\n";
            this.lblvin.Click += new System.EventHandler(this.lblvin_Click);
            // 
            // lblmarque
            // 
            this.lblmarque.AutoSize = true;
            this.lblmarque.Location = new System.Drawing.Point(298, 41);
            this.lblmarque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmarque.Name = "lblmarque";
            this.lblmarque.Size = new System.Drawing.Size(45, 13);
            this.lblmarque.TabIndex = 11;
            this.lblmarque.Text = "marque:";
            // 
            // lblmodele
            // 
            this.lblmodele.AutoSize = true;
            this.lblmodele.Location = new System.Drawing.Point(298, 71);
            this.lblmodele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmodele.Name = "lblmodele";
            this.lblmodele.Size = new System.Drawing.Size(44, 13);
            this.lblmodele.TabIndex = 12;
            this.lblmodele.Text = "modele:";
            // 
            // lblproprietaire
            // 
            this.lblproprietaire.AutoSize = true;
            this.lblproprietaire.Location = new System.Drawing.Point(298, 161);
            this.lblproprietaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblproprietaire.Name = "lblproprietaire";
            this.lblproprietaire.Size = new System.Drawing.Size(62, 13);
            this.lblproprietaire.TabIndex = 13;
            this.lblproprietaire.Text = "proprietaire:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lblproprietaire);
            this.panel1.Controls.Add(this.lblmodele);
            this.panel1.Controls.Add(this.lblmarque);
            this.panel1.Controls.Add(this.lblvin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 188);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "valeur de l\'achat:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "annee de fabrication:\r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnajouter);
            this.flowLayoutPanel1.Controls.Add(this.btnmodifier);
            this.flowLayoutPanel1.Controls.Add(this.btnvider);
            this.flowLayoutPanel1.Controls.Add(this.btnsupprimer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(772, 19);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(94, 142);
            this.flowLayoutPanel1.TabIndex = 21;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnajouter.Location = new System.Drawing.Point(2, 2);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(86, 28);
            this.btnajouter.TabIndex = 15;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnmodifier.Location = new System.Drawing.Point(2, 34);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(86, 28);
            this.btnmodifier.TabIndex = 17;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            // 
            // btnvider
            // 
            this.btnvider.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnvider.Location = new System.Drawing.Point(2, 66);
            this.btnvider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnvider.Name = "btnvider";
            this.btnvider.Size = new System.Drawing.Size(86, 28);
            this.btnvider.TabIndex = 18;
            this.btnvider.Text = "Vider";
            this.btnvider.UseVisualStyleBackColor = false;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.Crimson;
            this.btnsupprimer.Location = new System.Drawing.Point(2, 98);
            this.btnsupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(86, 28);
            this.btnsupprimer.TabIndex = 19;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            // 
            // dgvDeclarations
            // 
            this.dgvDeclarations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeclarations.Location = new System.Drawing.Point(22, 383);
            this.dgvDeclarations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDeclarations.Name = "dgvDeclarations";
            this.dgvDeclarations.ReadOnly = true;
            this.dgvDeclarations.RowHeadersWidth = 51;
            this.dgvDeclarations.RowTemplate.Height = 24;
            this.dgvDeclarations.Size = new System.Drawing.Size(825, 187);
            this.dgvDeclarations.TabIndex = 3;
            // 
            // grpdeclaration
            // 
            this.grpdeclaration.Controls.Add(this.btnenregistrer);
            this.grpdeclaration.Controls.Add(this.txtdatedecl);
            this.grpdeclaration.Controls.Add(this.txtnumero);
            this.grpdeclaration.Controls.Add(this.lblrep);
            this.grpdeclaration.Controls.Add(this.label2);
            this.grpdeclaration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpdeclaration.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpdeclaration.Location = new System.Drawing.Point(28, 273);
            this.grpdeclaration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpdeclaration.Name = "grpdeclaration";
            this.grpdeclaration.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpdeclaration.Size = new System.Drawing.Size(575, 93);
            this.grpdeclaration.TabIndex = 4;
            this.grpdeclaration.TabStop = false;
            this.grpdeclaration.Text = "Détails de déclaration";
            this.grpdeclaration.Enter += new System.EventHandler(this.grpdeclaration_Enter);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.Black;
            this.btnenregistrer.ImageIndex = 0;
            this.btnenregistrer.Location = new System.Drawing.Point(459, 34);
            this.btnenregistrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(108, 35);
            this.btnenregistrer.TabIndex = 14;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnenregistrer.UseVisualStyleBackColor = false;
            // 
            // txtdatedecl
            // 
            this.txtdatedecl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdatedecl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtdatedecl.Location = new System.Drawing.Point(206, 58);
            this.txtdatedecl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdatedecl.Multiline = true;
            this.txtdatedecl.Name = "txtdatedecl";
            this.txtdatedecl.Size = new System.Drawing.Size(238, 28);
            this.txtdatedecl.TabIndex = 13;
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnumero.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtnumero.Location = new System.Drawing.Point(206, 26);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(238, 28);
            this.txtnumero.TabIndex = 12;
            // 
            // lblrep
            // 
            this.lblrep.AutoSize = true;
            this.lblrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrep.ForeColor = System.Drawing.Color.Black;
            this.lblrep.Location = new System.Drawing.Point(62, 63);
            this.lblrep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrep.Name = "lblrep";
            this.lblrep.Size = new System.Drawing.Size(91, 26);
            this.lblrep.TabIndex = 1;
            this.lblrep.Text = "Date_declaration:\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(62, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero du repertoire:\r\n";
            // 
            // btnretour
            // 
            this.btnretour.ImageIndex = 1;
            this.btnretour.ImageList = this.imageretour;
            this.btnretour.Location = new System.Drawing.Point(9, 10);
            this.btnretour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(39, 31);
            this.btnretour.TabIndex = 5;
            this.btnretour.UseVisualStyleBackColor = true;
            // 
            // imageretour
            // 
            this.imageretour.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageretour.ImageStream")));
            this.imageretour.TransparentColor = System.Drawing.Color.Transparent;
            this.imageretour.Images.SetKeyName(0, "en-arriere.png");
            this.imageretour.Images.SetKeyName(1, "fleche-gauche.png");
            this.imageretour.Images.SetKeyName(2, "fleche-gauche.png");
            // 
            // btnsuivant
            // 
            this.btnsuivant.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsuivant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuivant.ForeColor = System.Drawing.Color.Black;
            this.btnsuivant.ImageIndex = 0;
            this.btnsuivant.Location = new System.Drawing.Point(646, 307);
            this.btnsuivant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsuivant.Name = "btnsuivant";
            this.btnsuivant.Size = new System.Drawing.Size(108, 35);
            this.btnsuivant.TabIndex = 15;
            this.btnsuivant.Text = "Suivant";
            this.btnsuivant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsuivant.UseVisualStyleBackColor = false;
            // 
            // frmdeclarationvoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(943, 535);
            this.Controls.Add(this.btnsuivant);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.grpdeclaration);
            this.Controls.Add(this.dgvDeclarations);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(604, 495);
            this.Name = "frmdeclarationvoiture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmvoiture";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeclarations)).EndInit();
            this.grpdeclaration.ResumeLayout(false);
            this.grpdeclaration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtannee;
        private System.Windows.Forms.TextBox txtmodele;
        private System.Windows.Forms.TextBox txtmarque;
        private System.Windows.Forms.TextBox txtvin;
        private System.Windows.Forms.Label lblvin;
        private System.Windows.Forms.Label lblmarque;
        private System.Windows.Forms.Label lblmodele;
        private System.Windows.Forms.Label lblproprietaire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDeclarations;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnvider;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.GroupBox grpdeclaration;
        private System.Windows.Forms.TextBox txtdatedecl;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblrep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvaleur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboModeproprietaire;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.ImageList imageretour;
        private System.Windows.Forms.Button btnsuivant;
    }
}