using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace BAL
{
   public class BALLigCmd
    {

        public int AjouterLigCmd(DAL.LigCmd dal)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                {"@CodeProduit",dal.CodeProduit },
                {"@NumCmd",dal.NumCmd },
                {"@Qte",dal.Qte },
                {"@Prix",dal.Prix }
            };
            res = Global.ExecuteroleDbActionNomsParams(@"insert into LigCmd (CodeProduit,NumCmd,Qte,Prix) values (@CodeProduit,@NumCmd,@Qte,@Prix)", cn, tabPMNames);
            Global.seDeconnecter(cn);
            return res;
        }

        public int getMaxId()
        {
            OleDbConnection ocn = new OleDbConnection();
            ocn = BAL.Global.seConnecter(BAL.Global.cs);
            Object o1 = BAL.Global.ExecuterOleDBScalaire(@"select Max(NumCmd) from Commande;", ocn);
            int i = Int32.Parse(o1.ToString());
            BAL.Global.seDeconnecter(ocn);
            return i;
        }



        public void deleteLigCmd(string ch)
        {

            OleDbConnection cn = new OleDbConnection();
            cn = BAL.Global.seConnecter(BAL.Global.cs);
            BAL.Global.ExecuterOleDbAction(@"delete from LigCmd where NumCmd =" + ch, cn);
            BAL.Global.seDeconnecter(cn);
        }


        public void deleteLigCmd1(string ch,string ch1,string ch2)
        {

            OleDbConnection cn = new OleDbConnection();
            cn = BAL.Global.seConnecter(BAL.Global.cs);
            BAL.Global.ExecuterOleDbAction(@"delete from LigCmd where NumCmd =" + ch+ " and Qte = "+ch1+ " and Prix = "+ch2, cn);
            BAL.Global.seDeconnecter(cn);
        }





     /*   public int UpdateLigCmd(DAL.LigCmd dal)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                {"@CodeProduit",dal.CodeProduit },
                {"@NumCmd",dal.NumCmd },
                {"@Qte",dal.Qte },
                {"@Prix",dal.Prix }
            };
            res = Global.ExecuteroleDbActionNomsParams(@"UPDATE LigCmd set Qte = @Qte,Prix = @Prix where CodeProduit=@CodeProduit and NumCmd = @NumCmd" , cn, tabPMNames);
            Global.seDeconnecter(cn);
            return res;
        }


        */


    }
}
