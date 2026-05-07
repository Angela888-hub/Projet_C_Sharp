
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnvider = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.lblproprietaire = new System.Windows.Forms.Label();
            this.lblmodele = new System.Windows.Forms.Label();
            this.lblmarque = new System.Windows.Forms.Label();
            this.lblvin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboModeproprietaire = new System.Windows.Forms.ComboBox();
            this.txtvaleur = new System.Windows.Forms.TextBox();
            this.txtannee = new System.Windows.Forms.TextBox();
            this.txtmodele = new System.Windows.Forms.TextBox();
            this.txtmarque = new System.Windows.Forms.TextBox();
            this.txtvin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsuivant = new System.Windows.Forms.Button();
            this.dgvDeclarations = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.grpdeclaration = new System.Windows.Forms.GroupBox();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.txtdatedecl = new System.Windows.Forms.TextBox();
            this.lblrep = new System.Windows.Forms.Label();
            this.imageretour = new System.Windows.Forms.ImageList(this.components);
            this.btnretour = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeclarations)).BeginInit();
            this.grpdeclaration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(0, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(1464, 46);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "                                                             GESTION DE DOUANE DE" +
    " VOITURE";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 612);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.lblproprietaire);
            this.panel2.Controls.Add(this.lblmodele);
            this.panel2.Controls.Add(this.lblmarque);
            this.panel2.Controls.Add(this.lblvin);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 243);
            this.panel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "valeur de l\'achat:\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "annee de fabrication:\r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnajouter);
            this.flowLayoutPanel1.Controls.Add(this.btnmodifier);
            this.flowLayoutPanel1.Controls.Add(this.btnvider);
            this.flowLayoutPanel1.Controls.Add(this.btnsupprimer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1089, 8);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(124, 168);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnajouter.Location = new System.Drawing.Point(3, 2);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(115, 34);
            this.btnajouter.TabIndex = 15;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnmodifier.Location = new System.Drawing.Point(3, 40);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(115, 34);
            this.btnmodifier.TabIndex = 17;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            // 
            // btnvider
            // 
            this.btnvider.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnvider.Location = new System.Drawing.Point(3, 78);
            this.btnvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvider.Name = "btnvider";
            this.btnvider.Size = new System.Drawing.Size(115, 34);
            this.btnvider.TabIndex = 18;
            this.btnvider.Text = "Vider";
            this.btnvider.UseVisualStyleBackColor = false;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.Crimson;
            this.btnsupprimer.Location = new System.Drawing.Point(3, 116);
            this.btnsupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(115, 34);
            this.btnsupprimer.TabIndex = 19;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            // 
            // lblproprietaire
            // 
            this.lblproprietaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblproprietaire.AutoSize = true;
            this.lblproprietaire.Location = new System.Drawing.Point(421, 196);
            this.lblproprietaire.Name = "lblproprietaire";
            this.lblproprietaire.Size = new System.Drawing.Size(85, 17);
            this.lblproprietaire.TabIndex = 29;
            this.lblproprietaire.Text = "proprietaire:";
            // 
            // lblmodele
            // 
            this.lblmodele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmodele.AutoSize = true;
            this.lblmodele.Location = new System.Drawing.Point(421, 85);
            this.lblmodele.Name = "lblmodele";
            this.lblmodele.Size = new System.Drawing.Size(58, 17);
            this.lblmodele.TabIndex = 28;
            this.lblmodele.Text = "modele:";
            // 
            // lblmarque
            // 
            this.lblmarque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmarque.AutoSize = true;
            this.lblmarque.Location = new System.Drawing.Point(421, 48);
            this.lblmarque.Name = "lblmarque";
            this.lblmarque.Size = new System.Drawing.Size(60, 17);
            this.lblmarque.TabIndex = 27;
            this.lblmarque.Text = "marque:";
            // 
            // lblvin
            // 
            this.lblvin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblvin.AutoSize = true;
            this.lblvin.Location = new System.Drawing.Point(421, 12);
            this.lblvin.Name = "lblvin";
            this.lblvin.Size = new System.Drawing.Size(141, 17);
            this.lblvin.TabIndex = 26;
            this.lblvin.Text = "vin_numero_chassis:\r\n";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboModeproprietaire);
            this.panel3.Controls.Add(this.txtvaleur);
            this.panel3.Controls.Add(this.txtannee);
            this.panel3.Controls.Add(this.txtmodele);
            this.panel3.Controls.Add(this.txtmarque);
            this.panel3.Controls.Add(this.txtvin);
            this.panel3.Location = new System.Drawing.Point(613, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 223);
            this.panel3.TabIndex = 25;
            // 
            // comboModeproprietaire
            // 
            this.comboModeproprietaire.ForeColor = System.Drawing.Color.White;
            this.comboModeproprietaire.FormattingEnabled = true;
            this.comboModeproprietaire.Location = new System.Drawing.Point(27, 191);
            this.comboModeproprietaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboModeproprietaire.Name = "comboModeproprietaire";
            this.comboModeproprietaire.Size = new System.Drawing.Size(369, 24);
            this.comboModeproprietaire.TabIndex = 13;
            // 
            // txtvaleur
            // 
            this.txtvaleur.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtvaleur.ForeColor = System.Drawing.Color.White;
            this.txtvaleur.Location = new System.Drawing.Point(27, 153);
            this.txtvaleur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvaleur.Multiline = true;
            this.txtvaleur.Name = "txtvaleur";
            this.txtvaleur.Size = new System.Drawing.Size(369, 34);
            this.txtvaleur.TabIndex = 12;
            // 
            // txtannee
            // 
            this.txtannee.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtannee.ForeColor = System.Drawing.Color.White;
            this.txtannee.Location = new System.Drawing.Point(27, 116);
            this.txtannee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtannee.Multiline = true;
            this.txtannee.Name = "txtannee";
            this.txtannee.Size = new System.Drawing.Size(369, 34);
            this.txtannee.TabIndex = 11;
            // 
            // txtmodele
            // 
            this.txtmodele.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtmodele.ForeColor = System.Drawing.Color.White;
            this.txtmodele.Location = new System.Drawing.Point(27, 80);
            this.txtmodele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmodele.Multiline = true;
            this.txtmodele.Name = "txtmodele";
            this.txtmodele.Size = new System.Drawing.Size(369, 34);
            this.txtmodele.TabIndex = 10;
            // 
            // txtmarque
            // 
            this.txtmarque.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtmarque.ForeColor = System.Drawing.Color.White;
            this.txtmarque.Location = new System.Drawing.Point(27, 44);
            this.txtmarque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmarque.Multiline = true;
            this.txtmarque.Name = "txtmarque";
            this.txtmarque.Size = new System.Drawing.Size(369, 34);
            this.txtmarque.TabIndex = 9;
            // 
            // txtvin
            // 
            this.txtvin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtvin.ForeColor = System.Drawing.Color.White;
            this.txtvin.Location = new System.Drawing.Point(27, 7);
            this.txtvin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvin.Multiline = true;
            this.txtvin.Name = "txtvin";
            this.txtvin.Size = new System.Drawing.Size(369, 34);
            this.txtvin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "PROPRIETES DE LA VOITURE\r\n\r\n";
            // 
            // btnsuivant
            // 
            this.btnsuivant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsuivant.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsuivant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuivant.ForeColor = System.Drawing.Color.Black;
            this.btnsuivant.ImageIndex = 0;
            this.btnsuivant.Location = new System.Drawing.Point(1010, 42);
            this.btnsuivant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsuivant.Name = "btnsuivant";
            this.btnsuivant.Size = new System.Drawing.Size(154, 43);
            this.btnsuivant.TabIndex = 15;
            this.btnsuivant.Text = "Suivant";
            this.btnsuivant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsuivant.UseVisualStyleBackColor = false;
            this.btnsuivant.Click += new System.EventHandler(this.btnsuivant_Click_1);
            // 
            // dgvDeclarations
            // 
            this.dgvDeclarations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeclarations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeclarations.Location = new System.Drawing.Point(0, 452);
            this.dgvDeclarations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDeclarations.Name = "dgvDeclarations";
            this.dgvDeclarations.ReadOnly = true;
            this.dgvDeclarations.RowHeadersWidth = 51;
            this.dgvDeclarations.RowTemplate.Height = 24;
            this.dgvDeclarations.Size = new System.Drawing.Size(1257, 206);
            this.dgvDeclarations.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(83, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero du repertoire:\r\n";
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnumero.ForeColor = System.Drawing.Color.White;
            this.txtnumero.Location = new System.Drawing.Point(275, 32);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(316, 34);
            this.txtnumero.TabIndex = 12;
            // 
            // grpdeclaration
            // 
            this.grpdeclaration.Controls.Add(this.btnenregistrer);
            this.grpdeclaration.Controls.Add(this.btnsuivant);
            this.grpdeclaration.Controls.Add(this.txtdatedecl);
            this.grpdeclaration.Controls.Add(this.txtnumero);
            this.grpdeclaration.Controls.Add(this.lblrep);
            this.grpdeclaration.Controls.Add(this.label2);
            this.grpdeclaration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpdeclaration.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpdeclaration.Location = new System.Drawing.Point(0, 295);
            this.grpdeclaration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpdeclaration.Name = "grpdeclaration";
            this.grpdeclaration.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpdeclaration.Size = new System.Drawing.Size(1252, 153);
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
            this.btnenregistrer.Location = new System.Drawing.Point(743, 42);
            this.btnenregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(144, 43);
            this.btnenregistrer.TabIndex = 14;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtdatedecl
            // 
            this.txtdatedecl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdatedecl.ForeColor = System.Drawing.Color.White;
            this.txtdatedecl.Location = new System.Drawing.Point(275, 71);
            this.txtdatedecl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdatedecl.Multiline = true;
            this.txtdatedecl.Name = "txtdatedecl";
            this.txtdatedecl.Size = new System.Drawing.Size(316, 34);
            this.txtdatedecl.TabIndex = 13;
            // 
            // lblrep
            // 
            this.lblrep.AutoSize = true;
            this.lblrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrep.ForeColor = System.Drawing.Color.Black;
            this.lblrep.Location = new System.Drawing.Point(83, 78);
            this.lblrep.Name = "lblrep";
            this.lblrep.Size = new System.Drawing.Size(120, 34);
            this.lblrep.TabIndex = 1;
            this.lblrep.Text = "Date_declaration:\r\n\r\n";
            // 
            // imageretour
            // 
            this.imageretour.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageretour.ImageStream")));
            this.imageretour.TransparentColor = System.Drawing.Color.Transparent;
            this.imageretour.Images.SetKeyName(0, "en-arriere.png");
            this.imageretour.Images.SetKeyName(1, "fleche-gauche.png");
            this.imageretour.Images.SetKeyName(2, "fleche-gauche.png");
            // 
            // btnretour
            // 
            this.btnretour.ImageIndex = 1;
            this.btnretour.ImageList = this.imageretour;
            this.btnretour.Location = new System.Drawing.Point(12, 4);
            this.btnretour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(52, 38);
            this.btnretour.TabIndex = 5;
            this.btnretour.UseVisualStyleBackColor = true;
            // 
            // frmdeclarationvoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1257, 658);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.grpdeclaration);
            this.Controls.Add(this.dgvDeclarations);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(799, 598);
            this.Name = "frmdeclarationvoiture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmvoiture";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeclarations)).EndInit();
            this.grpdeclaration.ResumeLayout(false);
            this.grpdeclaration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsuivant;
        private System.Windows.Forms.DataGridView dgvDeclarations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.GroupBox grpdeclaration;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.TextBox txtdatedecl;
        private System.Windows.Forms.Label lblrep;
        private System.Windows.Forms.ImageList imageretour;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnvider;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Label lblproprietaire;
        private System.Windows.Forms.Label lblmodele;
        private System.Windows.Forms.Label lblmarque;
        private System.Windows.Forms.Label lblvin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboModeproprietaire;
        private System.Windows.Forms.TextBox txtvaleur;
        private System.Windows.Forms.TextBox txtannee;
        private System.Windows.Forms.TextBox txtmodele;
        private System.Windows.Forms.TextBox txtmarque;
        private System.Windows.Forms.TextBox txtvin;
        private System.Windows.Forms.Label label1;
    }
}