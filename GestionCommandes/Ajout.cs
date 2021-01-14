using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BAL;
using DAL;
namespace GestionCommandes
{
    public partial class Ajout : Form
    {
        BALCommande bl;
        BALLigCmd ll;
        Commande dl;
        string ch1;
        string idClient;
        public Ajout(string ch,string idCl)
        
        {
          ch1 = ch;
            idClient = idCl;
            InitializeComponent();
            txtReference.Text = ch;
            remplirDatagrdview();


        }
        private void Ajout_Load(object sender, EventArgs e)
        {
            remplirDatagrdview();
        }
        private void remplirDatagrdview()
        {
            dataGridLigneCmd.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lect;
            cn = BAL.Global.seConnecter(BAL.Global.cs);
            lect = BAL.Global.ExecuterOleDBSelect(@"select Produit.Designation,LigCmd.Qte,LigCmd.Prix from Produit ,LigCmd where Produit.CodeProduit=LigCmd.CodeProduit and LigCmd.NumCmd =" + ch1, cn);
            while (lect.Read())
            {
                dataGridLigneCmd.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1), lect.GetValue(2));
            }
            BAL.Global.seDeconnecter(cn);
            lect.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void txtCodePostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {


            
    }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



     



        private void btnAjouter_Click(object sender, EventArgs e)
        {
            

            AjoutLC f1 = new AjoutLC(ch1, idClient);
            this.Dispose();
            f1.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {



            if (dataGridLigneCmd.SelectedRows.Count == 1)
            {
                ModifLigCmd f1 = new ModifLigCmd (ch1, idClient);


                OleDbConnection cn = new OleDbConnection();
                OleDbDataReader lect;
                cn = Global.seConnecter(Global.cs);
                string de = dataGridLigneCmd.SelectedRows[0].Cells[0].Value.ToString();
                de = "'" + de + "'";
                lect = Global.ExecuterOleDBSelect(@"select * from Produit where Designation = " + de, cn);

                while (lect.Read())
                {


                    f1.txtProduit.Text = lect.GetValue(0).ToString();
                    f1.txtType.Text = lect.GetValue(2).ToString();
                    f1.txtDesignation.Text = lect.GetValue(1).ToString();
                    
                }
                Global.seDeconnecter(cn);
                lect.Close();

                f1.ShowDialog();


            }


            else
            {
                MessageBox.Show("Selectionner le commande souhaiter" + "\n" + "Selectionner la ligne entiere.", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
















        }
   








        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridLigneCmd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectionner la ligne entiere." + "\n" + "Cliquer sur le curseur à gauche du datagid", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Voulez vous supprimer ce ligne de commande?", "Confirmation de la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
               
                ll = new BALLigCmd();

                ll.deleteLigCmd1(ch1, dataGridLigneCmd.SelectedRows[0].Cells[1].Value.ToString(), dataGridLigneCmd.SelectedRows[0].Cells[2].Value.ToString());

                remplirDatagrdview();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            ll = new BALLigCmd();

            ll.deleteLigCmd(ch1);

            this.Dispose();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string idClient1 = idClient;

            int res;
            bl = new BALCommande();
            dl = new Commande();
            bl.deleteCommande(ch1);
            dl.NumCmd = Int32.Parse(ch1);
            dl.DateCmd = dateCom.Text ; 
            dl.NumClient = Int32.Parse(idClient1) ;


            res = bl.AjouterCommande(dl);


            if (res == 1)
            {
                MessageBox.Show("Succès Ajout de nouveau commande.");
                Form1 f1 = new Form1();

                this.Dispose();

                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Echec Ajout de nouveau client.");
            }
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

     

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtClient_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void txtClient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                ClientAdd f1 = new ClientAdd(txtReference.Text);
                this.Dispose();
                f1.ShowDialog();
            }
        }

        private void txtReference_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
