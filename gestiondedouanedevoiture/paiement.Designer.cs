
namespace gestiondedouanedevoiture
{
    partial class paiement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paiement));
            this.lblgestion = new System.Windows.Forms.Label();
            this.comboModePaiement = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdDeclaration = new System.Windows.Forms.Label();
            this.txtIdDecl = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.Datetime = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblid_declaration = new System.Windows.Forms.Label();
            this.txtIdDeclaration = new System.Windows.Forms.TextBox();
            this.lblmontant = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lbltva = new System.Windows.Forms.Label();
            this.txtTVA = new System.Windows.Forms.TextBox();
            this.lblstatut = new System.Windows.Forms.Label();
            this.txtstatut = new System.Windows.Forms.TextBox();
            this.TAXES = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcalcultotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.btnretour = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnsuivant = new System.Windows.Forms.Button();
            this.TAXES.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblgestion
            // 
            this.lblgestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestion.Location = new System.Drawing.Point(547, 9);
            this.lblgestion.Name = "lblgestion";
            this.lblgestion.Size = new System.Drawing.Size(813, 46);
            this.lblgestion.TabIndex = 0;
            this.lblgestion.Text = "GESTION DE DOUANE DE VOITURE";
            // 
            // comboModePaiement
            // 
            this.comboModePaiement.AutoCompleteCustomSource.AddRange(new string[] {
            "Espèces",
            "Chèque bancaire",
            "Mvola"});
            this.comboModePaiement.FormattingEnabled = true;
            this.comboModePaiement.Items.AddRange(new object[] {
            "Espèces",
            "Chèque bancaire",
            "Mvola"});
            this.comboModePaiement.Location = new System.Drawing.Point(344, 265);
            this.comboModePaiement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboModePaiement.Name = "comboModePaiement";
            this.comboModePaiement.Size = new System.Drawing.Size(121, 50);
            this.comboModePaiement.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(99, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "PAIEMENT VIA:";
            // 
            // lblIdDeclaration
            // 
            this.lblIdDeclaration.AutoSize = true;
            this.lblIdDeclaration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDeclaration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdDeclaration.Location = new System.Drawing.Point(99, 89);
            this.lblIdDeclaration.Name = "lblIdDeclaration";
            this.lblIdDeclaration.Size = new System.Drawing.Size(140, 25);
            this.lblIdDeclaration.TabIndex = 9;
            this.lblIdDeclaration.Text = "Id_declaration:";
            // 
            // txtIdDecl
            // 
            this.txtIdDecl.Location = new System.Drawing.Point(315, 73);
            this.txtIdDecl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdDecl.Multiline = true;
            this.txtIdDecl.Name = "txtIdDecl";
            this.txtIdDecl.Size = new System.Drawing.Size(181, 38);
            this.txtIdDecl.TabIndex = 10;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldate.Location = new System.Drawing.Point(99, 153);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(59, 25);
            this.lbldate.TabIndex = 11;
            this.lbldate.Text = "Date:";
            // 
            // Datetime
            // 
            this.Datetime.Location = new System.Drawing.Point(315, 137);
            this.Datetime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Datetime.Multiline = true;
            this.Datetime.Name = "Datetime";
            this.Datetime.ReadOnly = true;
            this.Datetime.Size = new System.Drawing.Size(181, 38);
            this.Datetime.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(99, 215);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 25);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(315, 201);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(181, 38);
            this.txtTotal.TabIndex = 14;
            // 
            // lblid_declaration
            // 
            this.lblid_declaration.AutoSize = true;
            this.lblid_declaration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_declaration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblid_declaration.Location = new System.Drawing.Point(5, 58);
            this.lblid_declaration.Name = "lblid_declaration";
            this.lblid_declaration.Size = new System.Drawing.Size(140, 25);
            this.lblid_declaration.TabIndex = 0;
            this.lblid_declaration.Text = "Id_declaration:";
            // 
            // txtIdDeclaration
            // 
            this.txtIdDeclaration.Location = new System.Drawing.Point(189, 57);
            this.txtIdDeclaration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdDeclaration.Multiline = true;
            this.txtIdDeclaration.Name = "txtIdDeclaration";
            this.txtIdDeclaration.Size = new System.Drawing.Size(181, 38);
            this.txtIdDeclaration.TabIndex = 1;
            // 
            // lblmontant
            // 
            this.lblmontant.AutoSize = true;
            this.lblmontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmontant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmontant.Location = new System.Drawing.Point(12, 134);
            this.lblmontant.Name = "lblmontant";
            this.lblmontant.Size = new System.Drawing.Size(89, 25);
            this.lblmontant.TabIndex = 2;
            this.lblmontant.Text = "Montant:\r\n";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(189, 135);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontant.Multiline = true;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.ReadOnly = true;
            this.txtMontant.Size = new System.Drawing.Size(181, 38);
            this.txtMontant.TabIndex = 3;
            // 
            // lbltva
            // 
            this.lbltva.AutoSize = true;
            this.lbltva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltva.Location = new System.Drawing.Point(19, 210);
            this.lbltva.Name = "lbltva";
            this.lbltva.Size = new System.Drawing.Size(59, 25);
            this.lbltva.TabIndex = 5;
            this.lbltva.Text = "TVA:";
            this.lbltva.Click += new System.EventHandler(this.lbltva_Click);
            // 
            // txtTVA
            // 
            this.txtTVA.Location = new System.Drawing.Point(189, 217);
            this.txtTVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTVA.Multiline = true;
            this.txtTVA.Name = "txtTVA";
            this.txtTVA.ReadOnly = true;
            this.txtTVA.Size = new System.Drawing.Size(181, 38);
            this.txtTVA.TabIndex = 6;
            // 
            // lblstatut
            // 
            this.lblstatut.AutoSize = true;
            this.lblstatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblstatut.Location = new System.Drawing.Point(99, 341);
            this.lblstatut.Name = "lblstatut";
            this.lblstatut.Size = new System.Drawing.Size(69, 25);
            this.lblstatut.TabIndex = 7;
            this.lblstatut.Text = "Statut:";
            // 
            // txtstatut
            // 
            this.txtstatut.Location = new System.Drawing.Point(315, 341);
            this.txtstatut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstatut.Multiline = true;
            this.txtstatut.Name = "txtstatut";
            this.txtstatut.ReadOnly = true;
            this.txtstatut.Size = new System.Drawing.Size(181, 38);
            this.txtstatut.TabIndex = 8;
            // 
            // TAXES
            // 
            this.TAXES.Controls.Add(this.button1);
            this.TAXES.Controls.Add(this.txtcalcultotal);
            this.TAXES.Controls.Add(this.lbltva);
            this.TAXES.Controls.Add(this.txtTVA);
            this.TAXES.Controls.Add(this.lblmontant);
            this.TAXES.Controls.Add(this.lblid_declaration);
            this.TAXES.Controls.Add(this.txtMontant);
            this.TAXES.Controls.Add(this.txtIdDeclaration);
            this.TAXES.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAXES.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TAXES.Location = new System.Drawing.Point(238, 263);
            this.TAXES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TAXES.Name = "TAXES";
            this.TAXES.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TAXES.Size = new System.Drawing.Size(653, 461);
            this.TAXES.TabIndex = 5;
            this.TAXES.TabStop = false;
            this.TAXES.Text = "TAXES";
            this.TAXES.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculer";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtcalcultotal
            // 
            this.txtcalcultotal.Location = new System.Drawing.Point(189, 295);
            this.txtcalcultotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcalcultotal.Multiline = true;
            this.txtcalcultotal.Name = "txtcalcultotal";
            this.txtcalcultotal.Size = new System.Drawing.Size(181, 38);
            this.txtcalcultotal.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtstatut);
            this.groupBox1.Controls.Add(this.lblstatut);
            this.groupBox1.Controls.Add(this.btnenregistrer);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblIdDeclaration);
            this.groupBox1.Controls.Add(this.Datetime);
            this.groupBox1.Controls.Add(this.comboModePaiement);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdDecl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(975, 263);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(661, 458);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PAIEMENT";
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.Location = new System.Drawing.Point(481, 399);
            this.btnenregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(144, 36);
            this.btnenregistrer.TabIndex = 9;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnretour
            // 
            this.btnretour.ImageIndex = 0;
            this.btnretour.ImageList = this.imageList2;
            this.btnretour.Location = new System.Drawing.Point(114, 9);
            this.btnretour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(52, 38);
            this.btnretour.TabIndex = 39;
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "fleche-gauche.png");
            // 
            // btnsuivant
            // 
            this.btnsuivant.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsuivant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuivant.Location = new System.Drawing.Point(1157, 606);
            this.btnsuivant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsuivant.Name = "btnsuivant";
            this.btnsuivant.Size = new System.Drawing.Size(144, 36);
            this.btnsuivant.TabIndex = 15;
            this.btnsuivant.Text = "Suivant";
            this.btnsuivant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsuivant.UseVisualStyleBackColor = false;
            // 
            // paiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 706);
            this.Controls.Add(this.btnsuivant);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TAXES);
            this.Controls.Add(this.lblgestion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "paiement";
            this.Text = "paiement";
            this.TAXES.ResumeLayout(false);
            this.TAXES.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblgestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboModePaiement;
        private System.Windows.Forms.TextBox txtIdDecl;
        private System.Windows.Forms.Label lblIdDeclaration;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox Datetime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblid_declaration;
        private System.Windows.Forms.TextBox txtIdDeclaration;
        private System.Windows.Forms.Label lblmontant;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lbltva;
        private System.Windows.Forms.TextBox txtTVA;
        private System.Windows.Forms.Label lblstatut;
        private System.Windows.Forms.TextBox txtstatut;
        private System.Windows.Forms.GroupBox TAXES;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Button btnsuivant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcalcultotal;
    }
}