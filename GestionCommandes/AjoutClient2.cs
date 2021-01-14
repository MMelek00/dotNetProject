using BAL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommandes
{
    public partial class AjoutClient2 : Form
    {
        BALClient bl;
        Client dl;
        string ch1;

        public AjoutClient2(string ch)
        {
            InitializeComponent();
            ch1 = ch;

        }
            private void btnValider_Click(object sender, EventArgs e)
        {

            int res;
            bl = new BALClient();
            dl = new Client();
            dl.NumClient = bl.getMaxId() + 1;
            dl.NomClient = txtClient.Text;
            dl.Rue = txtRue.Text;
            dl.Ville = txtVille.Text;
            dl.CP = Int32.Parse(txtCP.Text);
            dl.Tel = Int32.Parse(txtTel.Text);
            res = bl.AjouterClient(dl);
            if (res == 1)
            {
                MessageBox.Show("Succès Ajout de nouveau client.");
                ClientAdd win;
                win = new ClientAdd(ch1);
                win.Show();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Echec Ajout de nouveau client.");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous annuler l'ajout?", "Annulation de l'ajout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ClientAdd win;
                win = new ClientAdd(ch1);
                this.Dispose();
                win.Show();
            }
        }

        private void txtVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AjoutClient2_Load(object sender, EventArgs e)
        {

        }
    }
}
