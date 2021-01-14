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
using System.Data.OleDb;

namespace GestionCommandes
{
    public partial class AjoutLC : Form
    {
        BALLigCmd bl;
        LigCmd dl;
       
        string reef;
        string idClient;

        public AjoutLC(string refe, string id)
        {
            InitializeComponent();
            reef = refe;
            idClient = id;
        }
        private void EnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                AjoutProduit f1 = new AjoutProduit(reef,idClient);
                this.Dispose();
                f1.ShowDialog();
            }
        }
        private void txtProduit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {




            int res;
            bl = new BALLigCmd();
            dl = new LigCmd();
            dl.NumCmd = Int32.Parse(reef);
            dl.CodeProduit = txtProduit.Text;
            dl.Qte= Int32.Parse(txtQte.Text);
            dl.Prix= Int32.Parse(txtPrix.Text);
            
            res = bl.AjouterLigCmd(dl);
            if (res == 1)
            {

                Ajout f1 = new Ajout(reef, idClient);




                OleDbConnection cn = new OleDbConnection();
                OleDbDataReader lect;
                cn = Global.seConnecter(Global.cs);
                lect = Global.ExecuterOleDBSelect(@"select * from Client where NumClient ="+ idClient, cn);
                while (lect.Read())
                {



                f1.txtClient.Text = lect.GetValue(1).ToString();
                f1.txtRue.Text = lect.GetValue(2).ToString();
                f1.txtVille.Text = lect.GetValue(3).ToString();
                f1.txtCodePostal.Text = lect.GetValue(4).ToString();
                f1.txtTel.Text = lect.GetValue(5).ToString();
                }
                Global.seDeconnecter(cn);
                lect.Close();

                this.Dispose();
                f1.ShowDialog();


            }
            else
            {
                MessageBox.Show("Echec Ajout de Ligne Comm.");
            }


















        }

        private void txtAnnuler_Click(object sender, EventArgs e)
        {
            Ajout f1 = new Ajout(reef, idClient);
            this.Dispose();
            f1.ShowDialog();
        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjoutLC_Load(object sender, EventArgs e)
        {

        }

        private void txtProduit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Dispose();

                AjoutProduit f1 = new AjoutProduit(reef, idClient);
                f1.ShowDialog();
            }
     
        }









        public int getIdByName(string name)
        {
            name = "'" + name + "'";
            OleDbConnection ocn = new OleDbConnection();
            ocn = BAL.Global.seConnecter(BAL.Global.cs);
            Object o1 = BAL.Global.ExecuterOleDBScalaire(@"select NumClient from Client where NomClient = " + name, ocn);
            int i = Int32.Parse(o1.ToString());
            BAL.Global.seDeconnecter(ocn);
            return i;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
