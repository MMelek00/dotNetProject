using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace BAL
{
    public class BALCommande
    {
        public int AjouterCommande(DAL.Commande dal)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                {"@NumCmd",dal.NumCmd },
                {"@DateCmd",dal.DateCmd },
                {"@NumClient",dal.NumClient }
            };
            res = Global.ExecuteroleDbActionNomsParams(@"insert into Commande (NumCmd,DateCmd,NumClient) values (@NumCmd,@DateCmd,@NumClient)", cn, tabPMNames);
            Global.seDeconnecter(cn);
            return res;
        }

        public int getMaxRef()
        {
            OleDbConnection ocn = new OleDbConnection();
            ocn = BAL.Global.seConnecter(BAL.Global.cs);
            Object o1 = BAL.Global.ExecuterOleDBScalaire(@"select Max(NumCmd) from Commande;", ocn);
            int i = Int32.Parse(o1.ToString());
            BAL.Global.seDeconnecter(ocn);
            return i;
        }

        public void deleteCommande(string ch)
        {
           
            OleDbConnection cn = new OleDbConnection();
            cn = BAL.Global.seConnecter(BAL.Global.cs);
            BAL.Global.ExecuterOleDbAction(@"delete from commande where NumCmd =" + ch, cn);
            BAL.Global.seDeconnecter(cn);
        }



        public int getCommandbyId(DAL.Commande dl, string id)
        {
           
            OleDbConnection ocn = new OleDbConnection();
            ocn = BAL.Global.seConnecter(BAL.Global.cs);
            Object o1 = BAL.Global.ExecuterOleDBScalaire(@"select NumClient from Commande where NumCmd=" + id, ocn);
            int i = Int32.Parse(o1.ToString());
            BAL.Global.seDeconnecter(ocn);
            return i;




        }





        public int getCltbyIdcmd( string id)
        {

            OleDbConnection ocn = new OleDbConnection();
            ocn = BAL.Global.seConnecter(BAL.Global.cs);
            Object o1 = BAL.Global.ExecuterOleDBScalaire(@"select NumClient from Commande where NumCmd=" + id, ocn);
            int i = Int32.Parse(o1.ToString());
            BAL.Global.seDeconnecter(ocn);
            return i;




        }






    }
}
