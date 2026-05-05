
namespace gestiondedouanedevoiture
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnacceuil = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnvoiture = new System.Windows.Forms.Button();
            this.btnproprietaire = new System.Windows.Forms.Button();
            this.btnpaiement = new System.Windows.Forms.Button();
            this.btnquittance = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContenu = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.panelContenu.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(-1, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOUANE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnacceuil
            // 
            this.btnacceuil.FlatAppearance.BorderSize = 0;
            this.btnacceuil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnacceuil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnacceuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceuil.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacceuil.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnacceuil.ImageIndex = 0;
            this.btnacceuil.ImageList = this.imageList1;
            this.btnacceuil.Location = new System.Drawing.Point(0, 1);
            this.btnacceuil.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnacceuil.Name = "btnacceuil";
            this.btnacceuil.Size = new System.Drawing.Size(280, 131);
            this.btnacceuil.TabIndex = 1;
            this.btnacceuil.Text = "ACCUEIL";
            this.btnacceuil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacceuil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnacceuil.UseVisualStyleBackColor = true;
            this.btnacceuil.Click += new System.EventHandler(this.btnaccueil_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "maison.png");
            this.imageList1.Images.SetKeyName(1, "auto.png");
            this.imageList1.Images.SetKeyName(2, "boutique-automobile.png");
            this.imageList1.Images.SetKeyName(3, "declaration-dimpot.png");
            this.imageList1.Images.SetKeyName(4, "paiement.png");
            this.imageList1.Images.SetKeyName(5, "facture.png");
            // 
            // btnvoiture
            // 
            this.btnvoiture.FlatAppearance.BorderSize = 0;
            this.btnvoiture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnvoiture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnvoiture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoiture.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoiture.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnvoiture.ImageIndex = 1;
            this.btnvoiture.ImageList = this.imageList1;
            this.btnvoiture.Location = new System.Drawing.Point(0, 267);
            this.btnvoiture.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnvoiture.Name = "btnvoiture";
            this.btnvoiture.Size = new System.Drawing.Size(280, 131);
            this.btnvoiture.TabIndex = 2;
            this.btnvoiture.Text = "VOITURE";
            this.btnvoiture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoiture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvoiture.UseVisualStyleBackColor = true;
            this.btnvoiture.Click += new System.EventHandler(this.btnvoiture_Click);
            // 
            // btnproprietaire
            // 
            this.btnproprietaire.FlatAppearance.BorderSize = 0;
            this.btnproprietaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnproprietaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnproprietaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproprietaire.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproprietaire.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnproprietaire.ImageIndex = 2;
            this.btnproprietaire.ImageList = this.imageList1;
            this.btnproprietaire.Location = new System.Drawing.Point(0, 134);
            this.btnproprietaire.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnproprietaire.Name = "btnproprietaire";
            this.btnproprietaire.Size = new System.Drawing.Size(280, 131);
            this.btnproprietaire.TabIndex = 3;
            this.btnproprietaire.Text = "PROPRIETAIRE";
            this.btnproprietaire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproprietaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproprietaire.UseVisualStyleBackColor = true;
            this.btnproprietaire.Click += new System.EventHandler(this.btnproprietaire_Click);
            // 
            // btnpaiement
            // 
            this.btnpaiement.FlatAppearance.BorderSize = 0;
            this.btnpaiement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnpaiement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnpaiement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpaiement.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaiement.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnpaiement.ImageIndex = 4;
            this.btnpaiement.ImageList = this.imageList1;
            this.btnpaiement.Location = new System.Drawing.Point(0, 400);
            this.btnpaiement.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnpaiement.Name = "btnpaiement";
            this.btnpaiement.Size = new System.Drawing.Size(280, 131);
            this.btnpaiement.TabIndex = 5;
            this.btnpaiement.Text = "TAXES ET PAIEMENT";
            this.btnpaiement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpaiement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpaiement.UseVisualStyleBackColor = true;
            this.btnpaiement.Click += new System.EventHandler(this.btnpaiement_Click);
            // 
            // btnquittance
            // 
            this.btnquittance.FlatAppearance.BorderSize = 0;
            this.btnquittance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnquittance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnquittance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquittance.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquittance.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnquittance.ImageIndex = 5;
            this.btnquittance.ImageList = this.imageList1;
            this.btnquittance.Location = new System.Drawing.Point(0, 533);
            this.btnquittance.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnquittance.Name = "btnquittance";
            this.btnquittance.Size = new System.Drawing.Size(280, 131);
            this.btnquittance.TabIndex = 6;
            this.btnquittance.Text = "GENERER QUITTANCE";
            this.btnquittance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnquittance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnquittance.UseVisualStyleBackColor = true;
            this.btnquittance.Click += new System.EventHandler(this.btngenerer_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1260, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 140);
            this.label5.TabIndex = 10;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl1.Controls.Add(this.btnacceuil);
            this.pnl1.Controls.Add(this.btnproprietaire);
            this.pnl1.Controls.Add(this.btnvoiture);
            this.pnl1.Controls.Add(this.btnpaiement);
            this.pnl1.Controls.Add(this.btnquittance);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(291, 1055);
            this.pnl1.TabIndex = 18;
            this.pnl1.WrapContents = false;
            this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1_Paint);
            // 
            // panelContenu
            // 
            this.panelContenu.AutoScroll = true;
            this.panelContenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelContenu.Controls.Add(this.pnl3);
            this.panelContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenu.ForeColor = System.Drawing.SystemColors.Menu;
            this.panelContenu.Location = new System.Drawing.Point(291, 0);
            this.panelContenu.Name = "panelContenu";
            this.panelContenu.Size = new System.Drawing.Size(1633, 1055);
            this.panelContenu.TabIndex = 19;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl3.Controls.Add(this.label2);
            this.pnl3.Location = new System.Drawing.Point(0, 0);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1633, 84);
            this.pnl3.TabIndex = 0;
            this.pnl3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "GESTION DE DOUANE DE VOITURE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelContenu);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl1.ResumeLayout(false);
            this.panelContenu.ResumeLayout(false);
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnacceuil;
        private System.Windows.Forms.Button btnvoiture;
        private System.Windows.Forms.Button btnproprietaire;
        private System.Windows.Forms.Button btnpaiement;
        private System.Windows.Forms.Button btnquittance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel pnl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelContenu;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Label label2;
    }
}

