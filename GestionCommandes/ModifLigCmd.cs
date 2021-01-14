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
    public partial class ModifLigCmd : Form
    {
        BALLigCmd bl;
        LigCmd dl;

        string reef;
        string idClient;

        public ModifLigCmd(string refe, string id)
        {
            InitializeComponent();
            reef = refe;
            idClient = id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtProduit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bl = new BALLigCmd();
            dl = new LigCmd();
            /*  dl.NumCmd = Int32.Parse(reef);
              dl.CodeProduit = txtProduit.Text;
              dl.Qte = Int32.Parse(txtQte.Text);
              dl.Prix = Int32.Parse(txtPrix.Text);*/
            OleDbConnection ccn = new OleDbConnection();
            ccn = Global.seConnecter(Global.cs);
            string codeprd = "'" + txtProduit.Text + "'";

            Global.ExecuterOleDbAction(@"update LigCmd set LigCmd.Qte = " + Int32.Parse(txtQte.Text) + ", LigCmd.Prix = " + Int32.Parse(txtPrix.Text) + " where LigCmd.CodeProduit = " + codeprd + " and LigCmd.NumCmd = " + Int32.Parse(reef), ccn);


            Global.seDeconnecter(ccn);


            Ajout f1 = new Ajout(reef, idClient);




            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lect;
            cn = Global.seConnecter(Global.cs);
            lect = Global.ExecuterOleDBSelect(@"select * from Client where NumClient =" + idClient, cn);
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

        private void txtProduit_keyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                AjoutProduit f1 = new AjoutProduit(reef, idClient);
                this.Dispose();
                f1.ShowDialog();
            }
        }

        private void txtAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void ModifLigCmd_Load(object sender, EventArgs e)
        {

        }
    }
}
