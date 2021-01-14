using DAL;
using BAL;
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

namespace GestionCommandes
{
    public partial class Form1 : Form
    {
        BALCommande bl;
         Commande dl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remplirDatagrdview();
            remplirDatagrdview1();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string referance;
            BAL.BALCommande bl;
            bl = new BALCommande();


            referance = (bl.getMaxRef() + 1).ToString();
            Ajout f1 = new Ajout(referance,"");
            f1.ShowDialog();
        }



        private void gridList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*

            txtRef.Text = gridList.SelectedRows[0].Cells[0].Value.ToString();
            if (gridList.SelectedRows.Count == 1)
            {
                
                string id = "'" + gridList.SelectedRows[0].Cells[0].Value.ToString() + "'";

                OleDbConnection cn = new OleDbConnection();
                cn = BAL.Global.seConnecter(BAL.Global.cs);
                OleDbDataReader lecteur;

                lecteur = BAL.Global.ExecuterOleDBSelect(@"select * from Client,Commande where Client.NumClient=Commande.NumClient and Commande.NumCmd =" + id, cn);
                while (lecteur.Read())
                {
                    txtClient.Text = lecteur.GetValue(1).ToString();
                    txtAdresse.Text = lecteur.GetValue(2).ToString();
                    txtVille.Text = lecteur.GetValue(3).ToString();
                    txtCP.Text = lecteur.GetValue(4).ToString();
                    txtTel.Text = lecteur.GetValue(5).ToString();

                }
                BAL.Global.seDeconnecter(cn);
                lecteur.Close();
            }*/
        }

        private void remplirDatagrdview()
        {
            gridList.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lect;
            cn = BAL.Global.seConnecter(BAL.Global.cs);
            lect = BAL.Global.ExecuterOleDBSelect(@"select Commande.NumCmd,Commande.DateCmd,Client.NomClient from Commande ,Client where Commande.NumClient=Client.NumClient  order by Commande.NumCmd asc", cn);
            while (lect.Read())
            {
                gridList.Rows.Add(lect.GetValue(0), lect.GetValue(1), lect.GetValue(2).ToString());
            }
            BAL.Global.seDeconnecter(cn);
            lect.Close();

        }
        private void remplirDatagrdview1()
        {
            gridLigne.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lect;
            cn = BAL.Global.seConnecter(BAL.Global.cs);
            lect = BAL.Global.ExecuterOleDBSelect(@"select Produit.Designation,LigCmd.Qte,LigCmd.Prix from Produit ,LigCmd where Produit.CodeProduit=LigCmd.CodeProduit ", cn);
            while (lect.Read())
            {
                gridLigne.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1), lect.GetValue(2));
            }
            BAL.Global.seDeconnecter(cn);
            lect.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (gridList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectionner la ligne entiere." + "\n" + "Cliquer sur le curseur à gauche du datagid", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Voulez vous supprimer ce commande?", "Confirmation de la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                OleDbConnection cn = new OleDbConnection();
                cn = BAL.Global.seConnecter(BAL.Global.cs);
                BAL.Global.ExecuterOleDbAction(@"delete from Commande where NumCmd = " + gridList.SelectedRows[0].Cells[0].Value.ToString(), cn);
                BAL.Global.ExecuterOleDbAction(@"update LigCmd set NumCmd = 0 where NumCmd = " + gridList.SelectedRows[0].Cells[0].Value.ToString(), cn);
                BAL.Global.seDeconnecter(cn);
                remplirDatagrdview();
            }
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRef_TextChanged(object sender, EventArgs e)
        {
            string id = txtRef.Text;
            Boolean k = false;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] < '9' && id[i] > '0')
                {
                    k = true;
                }

            }

            if (id != "" && k)
            {
                OleDbConnection ocn = new OleDbConnection();
                ocn = BAL.Global.seConnecter(BAL.Global.cs);

                /////recherche pour grid 1
                Object o1 = BAL.Global.ExecuterOleDBScalaire(@"select DateCmd from Commande where NumCmd =" + id, ocn);
                Object o2 = BAL.Global.ExecuterOleDBScalaire(@"select Client.NomClient from Client,Commande where Client.NumClient=Commande.NumClient and Commande.NumCmd =" + id, ocn);

                /////recherche pour grid 2
                Object o3 = BAL.Global.ExecuterOleDBScalaire(@"select Produit.Designation from Produit,LigCmd where Produit.CodeProduit=LigCmd.CodeProduit and LigCmd.NumCmd =" + id, ocn);
                Object o4 = BAL.Global.ExecuterOleDBScalaire(@"select LigCmd.Qte from Produit,LigCmd where Produit.CodeProduit=LigCmd.CodeProduit and LigCmd.NumCmd =" + id, ocn);
                Object o5 = BAL.Global.ExecuterOleDBScalaire(@"select LigCmd.Prix from Produit,LigCmd where Produit.CodeProduit=LigCmd.CodeProduit and LigCmd.NumCmd =" + id, ocn);
                OleDbDataReader lecteur;

                lecteur = BAL.Global.ExecuterOleDBSelect(@"select * from Client,Commande where Client.NumClient=Commande.NumClient and Commande.NumCmd =" + id, ocn);
                while (lecteur.Read())
                {
                    txtClient.Text = lecteur.GetValue(1).ToString();
                    txtAdresse.Text = lecteur.GetValue(2).ToString();
                    txtVille.Text = lecteur.GetValue(3).ToString();
                    txtCP.Text = lecteur.GetValue(4).ToString();
                    txtTel.Text = lecteur.GetValue(5).ToString();

                }
                BAL.Global.seDeconnecter(ocn);
                lecteur.Close();

                if (o1 != null)
                {
                    ////add for grid 1
                    gridList.Rows.Clear();
                    gridList.Rows.Add(id, o1, o2.ToString());

                    ////add for grid 2
                    gridLigne.Rows.Clear();
                    gridLigne.Rows.Add(o3.ToString(), o4, o5);

                }

                else { }
                //MessageBox.Show("Client introuvable." + "\n" + "Cliquer sur le curseur à gauche du datagid", "Erreur du sold", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BAL.Global.seDeconnecter(ocn);
            }
            else
            {
                remplirDatagrdview();
                remplirDatagrdview1();
            }
        }

        private void txtClient1_TextChanged(object sender, EventArgs e)
        {
            /*string nom1 = txtClient1.Text;
            string nom = txtClient1.Text;


            if (nom != "")
            {
                nom = "'" + nom + "'";
                OleDbConnection ocn = new OleDbConnection();
                ocn = BAL.Global.seConnecter(BAL.Global.cs);

                ////recherche dans grid 1
                Object o1 = BAL.Global.ExecuterOleDBScalaire(@"select Commande.NumCmd from Commande,Client where Commande.NumClient=Client.NumClient and Client.NomClient like" + nom, ocn);
                Object o2 = BAL.Global.ExecuterOleDBScalaire(@"select Commande.DateCmd from Commande,Client where Commande.NumClient=Client.NumClient and Client.NomClient like" + nom, ocn);


                if (o1 != null)
                {
                    ////recherche dans grid 2
                    Object o3 = BAL.Global.ExecuterOleDBScalaire(@"select Produit.Designation from Produit,LigCmd where Produit.CodeProduit=LigCmd.CodeProduit and LigCmd.NumCmd =" + o1.ToString(), ocn);
                    Object o4 = BAL.Global.ExecuterOleDBScalaire(@"select LigCmd.Qte from Produit,LigCmd where Produit.CodeProduit=LigCmd.CodeProduit and LigCmd.NumCmd =" + o1.ToString(), ocn);
                    Object o5 = BAL.Global.ExecuterOleDBScalaire(@"select LigCmd.Prix from Produit,LigCmd where Produit.CodeProduit=LigCmd.CodeProduit and LigCmd.NumCmd =" + o1.ToString(), ocn);


                    ////add for grid 1
                    gridList.Rows.Clear();
                    gridList.Rows.Add(o1, o2, nom1);

                    ////add for grid 2
                    gridLigne.Rows.Clear();
                    gridLigne.Rows.Add(o3.ToString(), o4, o5);


                    OleDbDataReader lecteur;

                    lecteur = BAL.Global.ExecuterOleDBSelect(@"select * from Client where NomClient like" + nom, ocn);
                    while (lecteur.Read())
                    {
                        txtClient.Text = lecteur.GetValue(1).ToString();
                        txtAdresse.Text = lecteur.GetValue(2).ToString();
                        txtVille.Text = lecteur.GetValue(3).ToString();
                        txtCP.Text = lecteur.GetValue(4).ToString();
                        txtTel.Text = lecteur.GetValue(5).ToString();

                    }



                    BAL.Global.seDeconnecter(ocn);
                    lecteur.Close();

                }

                else { }
                //MessageBox.Show("Client introuvable." + "\n" + "Cliquer sur le curseur à gauche du datagid", "Erreur du sold", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BAL.Global.seDeconnecter(ocn);
            }
            else
            {
                remplirDatagrdview();
                remplirDatagrdview1();
            }*/








            
                string nom1 = txtClient1.Text;
                string nom = txtClient1.Text;


                ////recherche dans grid 1
                if (nom != "")
                {
                    nom = "'" + nom + "%'";
                    gridList.Rows.Clear();
                    gridLigne.Rows.Clear();
                    OleDbConnection cn = new OleDbConnection();
                    OleDbDataReader lect;
                    OleDbDataReader lect1;
                    OleDbDataReader lect2;

                    cn = BAL.Global.seConnecter(BAL.Global.cs);
                    lect = BAL.Global.ExecuterOleDBSelect(@"select * from Client where NomClient like " + nom, cn);
                    while (lect.Read())
                    {
                        lect1 = BAL.Global.ExecuterOleDBSelect(@"select * from Commande where NumClient = " + lect.GetValue(0).ToString(), cn);
                        while (lect1.Read())
                        {

                            gridList.Rows.Add(lect1.GetValue(0).ToString(), lect1.GetValue(1).ToString(),
                            lect.GetValue(1).ToString());
                            lect2 = BAL.Global.ExecuterOleDBSelect(@"select Produit.Designation,LigCmd.Qte,LigCmd.Prix from Produit,LigCmd where Produit.CodeProduit=LigCmd.CodeProduit and LigCmd.NumCmd = " + lect1.GetValue(0).ToString(), cn);
                            while (lect2.Read())
                            {

                                gridLigne.Rows.Add(lect2.GetValue(0).ToString(), lect2.GetValue(1).ToString(),
                                lect2.GetValue(2).ToString());

                            }
                        }

                    }
                    BAL.Global.seDeconnecter(cn);
                    lect.Close();

                }
                else
                {
                    remplirDatagrdview();
                    remplirDatagrdview1();
                }

            }








        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateDebut_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            if (gridList.SelectedRows.Count == 1)
            {



                string Idcmd = gridList.SelectedRows[0].Cells[0].Value.ToString();

                bl = new BALCommande();
                dl = new Commande();



                Ajout f1 = new Ajout(gridList.SelectedRows[0].Cells[0].Value.ToString(), bl.getCltbyIdcmd(Idcmd).ToString());



               OleDbConnection cn = new OleDbConnection();
                OleDbDataReader lect;
                cn = Global.seConnecter(Global.cs);
                lect = Global.ExecuterOleDBSelect(@"select * from Client where NumClient =" + Int32.Parse(bl.getCltbyIdcmd(Idcmd).ToString()), cn);
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

                f1.ShowDialog();



            }


            else
            {
                MessageBox.Show("Selectionner le commande souhaiter" + "\n" + "Selectionner la ligne entiere.", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }







        }


        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfilter_Click(object sender, EventArgs e)
        {

        }

        private void gridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridList.SelectedRows.Count == 1)
         

            {
                string IdCom = gridList.SelectedRows[0].Cells[0].Value.ToString();
                OleDbConnection cn = new OleDbConnection();
                cn = BAL.Global.seConnecter(BAL.Global.cs);
                DAL.Commande Cd;
                BAL.BALCommande Cb;
                Cd = new Commande();
                Cb = new BALCommande();
                int id = Cb.getCommandbyId(Cd, IdCom);
             string   idclt = id.ToString();
                BAL.BALClient bl;

                OleDbDataReader lect;

                lect = BAL.Global.ExecuterOleDBSelect(@"select * from Client where NumClient=" + idclt, cn);
                while (lect.Read())
                {
                    txtClient.Text = lect.GetValue(1).ToString();
                    txtAdresse.Text = lect.GetValue(2).ToString();
                    txtVille.Text = lect.GetValue(3).ToString();
                    txtCP.Text = lect.GetValue(4).ToString();
                    txtTel.Text = lect.GetValue(5).ToString();
                }
                BAL.Global.seDeconnecter(cn);
                lect.Close();

            }
            else
                {
                txtClient.Text = "";
                txtAdresse.Text = "";
                txtVille.Text = "";
                txtCP.Text = "";
                txtTel.Text = "";
            }






}

        private void gridLigne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
