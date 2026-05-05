
namespace gestiondedouanedevoiture
{
    partial class frmquittance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmquittance));
            this.lblgestion = new System.Windows.Forms.Label();
            this.txtIdDeclaration = new System.Windows.Forms.TextBox();
            this.lblIdDeclaration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btngenerer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnaccueil = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.btnretour = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblgestion
            // 
            this.lblgestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestion.Location = new System.Drawing.Point(282, -4);
            this.lblgestion.Name = "lblgestion";
            this.lblgestion.Size = new System.Drawing.Size(813, 45);
            this.lblgestion.TabIndex = 1;
            this.lblgestion.Text = "GESTION DE DOUANE DE VOITURE";
            // 
            // txtIdDeclaration
            // 
            this.txtIdDeclaration.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtIdDeclaration.Location = new System.Drawing.Point(121, 68);
            this.txtIdDeclaration.Multiline = true;
            this.txtIdDeclaration.Name = "txtIdDeclaration";
            this.txtIdDeclaration.Size = new System.Drawing.Size(201, 31);
            this.txtIdDeclaration.TabIndex = 2;
            this.txtIdDeclaration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIdDeclaration
            // 
            this.lblIdDeclaration.AutoSize = true;
            this.lblIdDeclaration.Location = new System.Drawing.Point(12, 71);
            this.lblIdDeclaration.Name = "lblIdDeclaration";
            this.lblIdDeclaration.Size = new System.Drawing.Size(103, 17);
            this.lblIdDeclaration.TabIndex = 3;
            this.lblIdDeclaration.Text = "Id_Declaration:";
            this.lblIdDeclaration.Click += new System.EventHandler(this.lblIdDeclaration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "\"Ce document atteste que les droits et taxes pour le véhicule ci-dessous ont été " +
    "acquittés.\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "\"QUITTANCE OFFICIELLE DE DEDOUANEMENT\"";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(590, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "REPUBLIQUE DE MADAGASCAR -ADMINISTRATION DE DOUANES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(633, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(218, 592);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(556, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "\"Document généré par le système informatique de gestion douanière le [Date du jou" +
    "r].\"";
            // 
            // btngenerer
            // 
            this.btngenerer.BackColor = System.Drawing.Color.MidnightBlue;
            this.btngenerer.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btngenerer.Location = new System.Drawing.Point(156, 105);
            this.btngenerer.Name = "btngenerer";
            this.btngenerer.Size = new System.Drawing.Size(105, 37);
            this.btngenerer.TabIndex = 32;
            this.btngenerer.Text = "Generer";
            this.btngenerer.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(338, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 658);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(125, 602);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 17);
            this.label18.TabIndex = 28;
            this.label18.Text = "Signature";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(128, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 503);
            this.panel1.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(312, 400);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 10);
            this.label17.TabIndex = 78;
            this.label17.Text = "label17";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Numero du repertoire:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(209, 208);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 31);
            this.textBox5.TabIndex = 65;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(461, 457);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(201, 31);
            this.textBox11.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Marque et modele:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(461, 417);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(201, 31);
            this.textBox10.TabIndex = 76;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(312, 426);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 17);
            this.label16.TabIndex = 75;
            this.label16.Text = "Mode de paiement:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "vin_numéro_chassis:\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(312, 463);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 17);
            this.label15.TabIndex = 74;
            this.label15.Text = "Date de paiement:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nom du proprietaire:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Date déclaration:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 31);
            this.textBox1.TabIndex = 61;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 31);
            this.textBox2.TabIndex = 62;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(461, 377);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(201, 31);
            this.textBox9.TabIndex = 73;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 122);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 31);
            this.textBox3.TabIndex = 63;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(461, 337);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(201, 31);
            this.textBox8.TabIndex = 72;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(209, 165);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 31);
            this.textBox4.TabIndex = 64;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(461, 297);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(201, 31);
            this.textBox7.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(312, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 66;
            this.label9.Text = "TOTAL:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(209, 251);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(201, 31);
            this.textBox6.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 67;
            this.label10.Text = "TVA:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 69;
            this.label12.Text = "Annee:\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 68;
            this.label11.Text = "Monant:";
            // 
            // btnaccueil
            // 
            this.btnaccueil.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnaccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccueil.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnaccueil.Location = new System.Drawing.Point(64, 624);
            this.btnaccueil.Name = "btnaccueil";
            this.btnaccueil.Size = new System.Drawing.Size(248, 56);
            this.btnaccueil.TabIndex = 35;
            this.btnaccueil.Text = "Accueil";
            this.btnaccueil.UseVisualStyleBackColor = false;
            // 
            // btnimprimer
            // 
            this.btnimprimer.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnimprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnimprimer.Location = new System.Drawing.Point(64, 543);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(248, 56);
            this.btnimprimer.TabIndex = 37;
            this.btnimprimer.Text = "Imprimer quittance";
            this.btnimprimer.UseVisualStyleBackColor = false;
            // 
            // btnretour
            // 
            this.btnretour.ImageIndex = 0;
            this.btnretour.ImageList = this.imageList1;
            this.btnretour.Location = new System.Drawing.Point(15, 12);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(52, 38);
            this.btnretour.TabIndex = 38;
            this.btnretour.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fleche-gauche.png");
            // 
            // frmquittance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 714);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.btnaccueil);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btngenerer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblIdDeclaration);
            this.Controls.Add(this.txtIdDeclaration);
            this.Controls.Add(this.lblgestion);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmquittance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmquittance";
            this.Load += new System.EventHandler(this.frmquittance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgestion;
        private System.Windows.Forms.TextBox txtIdDeclaration;
        private System.Windows.Forms.Label lblIdDeclaration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btngenerer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnaccueil;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.ImageList imageList1;
    }
}