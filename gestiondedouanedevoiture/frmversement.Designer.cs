
namespace gestiondedouanedevoiture
{
    partial class frmversement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmversement));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgvVersements = new System.Windows.Forms.DataGridView();
            this.btnretour = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersements)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "VERSEMENT";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(296, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(744, 46);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = " GESTION DE DOUANE DE VOITURE";
            // 
            // dgvVersements
            // 
            this.dgvVersements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVersements.Location = new System.Drawing.Point(42, 191);
            this.dgvVersements.Name = "dgvVersements";
            this.dgvVersements.RowHeadersWidth = 51;
            this.dgvVersements.RowTemplate.Height = 24;
            this.dgvVersements.Size = new System.Drawing.Size(1195, 398);
            this.dgvVersements.TabIndex = 3;
            // 
            // btnretour
            // 
            this.btnretour.ImageIndex = 0;
            this.btnretour.ImageList = this.imageList1;
            this.btnretour.Location = new System.Drawing.Point(42, 31);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(47, 36);
            this.btnretour.TabIndex = 4;
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fleche-gauche.png");
            // 
            // frmversement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 670);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.dgvVersements);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.Name = "frmversement";
            this.Text = "frmversement";
            this.Load += new System.EventHandler(this.Frmversement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgvVersements;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.ImageList imageList1;
    }
}