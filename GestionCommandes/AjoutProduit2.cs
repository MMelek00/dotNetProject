using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;
namespace GestionCommandes
{
    public partial class AjoutProduit2 : Form
    {
        BAL.BALProduit bl;
        DAL.Produit dl;
        BAL.BALTProduit cl;


        string reef;
        string idClient;



           
            public AjoutProduit2(string refe, string id)
        {
            reef = refe;
            idClient = id;
            InitializeComponent();
        }

        private void txtCodeProduit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
             int res;
            bl = new BALProduit();
            dl = new Produit();
            cl = new BALTProduit();
            
            dl.CodeProduit = txtCodeProduit.Text;
            dl.Designation = txtDesignation.Text;
            dl.CodeTProduit = cl.getCodeTProduit(TPBox.Text);
            res = bl.AjouterProduit(dl);
            if (res == 1)
            {
                MessageBox.Show("Succès Ajout de noucsdsdveau Produit."+ reef+"dfdfdf"+ idClient);
                AjoutProduit win;
                win = new AjoutProduit(reef,idClient);
                win.Show();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Echec Ajout de nouveau Produit.");
            }
        }
        

      

        private void TPBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            AjoutProduit f1 = new AjoutProduit(reef,idClient);
            this.Dispose();
            f1.ShowDialog();
        }

        private void AjoutProduit2_Load(object sender, EventArgs e)
        {

        }
    }
}
