using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiondedouanedevoiture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Cette méthode permet d'afficher un formulaire à l'intérieur de ton Panel gris
        /*public void loadform(object Form)
        {
            if (this.pnl2.Controls.Count > 0)
                this.pnl2.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None; // Enlever les bordures Windows
            this.pnl2.Controls.Add(f);
            this.pnl2.Tag = f;
            f.Show();
        }
        */
        // Exemple pour le bouton Voiture
       
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaccueil_Click(object sender, EventArgs e)
        {
            loadform(new frmaccueil());
        }

        private void btnvoiture_Click(object sender, EventArgs e)
        {
            loadform(new frmdeclarationvoiture());
        }

        private void btnproprietaire_Click(object sender, EventArgs e)
        {
            loadform(new frmproprietaire());
        }

        private void btnpaiement_Click(object sender, EventArgs e)
        {
            loadform(new paiement());
        }
        public void loadform(Form f)
        {
            if (this.panelContenu.Controls.Count > 0)
            {
                this.panelContenu.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;           // Très important
            f.AutoSize = true;

            this.panelContenu.Controls.Add(f);
            f.Show();
        }
        private void btngenerer_Click(object sender, EventArgs e)
        {
            loadform(new frmquittance());
        }
    }
}
