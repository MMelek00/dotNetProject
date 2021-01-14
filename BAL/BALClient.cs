using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace BAL
{
    public class BALClient
    {

        public int AjouterClient(DAL.Client dal)
        {
           
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                {"@NumClient",dal.NumClient },
                {"@NomClient",dal.NomClient },
                {"@Rue",dal.Rue },
                {"@Ville",dal.Ville },
                {"@CP",dal.CP },
                {"@Tel",dal.Tel }
            };
            res = Global.ExecuteroleDbActionNomsParams(@"insert into Client (NumClient,NomClient,Rue,Ville,CP,Tel) values (@NumClient,@NomClient,@Rue,@Ville,@CP,@Tel)", cn, tabPMNames);
            Global.seDeconnecter(cn);
            return res;
        }


        public void getClientbyName(DAL.Client dl, string name)
        {
            name = "'" + name + "'";

            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lect;
            cn = BAL.Global.seConnecter(BAL.Global.cs);
            lect = BAL.Global.ExecuterOleDBSelect(@"select * from Client where NomClient=" + name, cn);
            while (lect.Read())
            {
                dl.NumClient = Int32.Parse(lect.GetValue(0).ToString());
                dl.NomClient = lect.GetValue(1).ToString();
                dl.Rue = lect.GetValue(2).ToString();
                dl.Ville = lect.GetValue(3).ToString();
                dl.CP = Int32.Parse(lect.GetValue(4).ToString());
                dl.Tel = Int32.Parse(lect.GetValue(5).ToString());
            }

            BAL.Global.seDeconnecter(cn);
            lect.Close();

        }

        public int getMaxId()
        {
            OleDbConnection ocn = new OleDbConnection();
            ocn = BAL.Global.seConnecter(BAL.Global.cs);
            Object o1 = BAL.Global.ExecuterOleDBScalaire(@"select Max(NumClient) from Client;", ocn);
            int i = Int32.Parse(o1.ToString());
            BAL.Global.seDeconnecter(ocn);
            return i;
        }

        public void deleteClient(string ch)
        {
           
            OleDbConnection cn = new OleDbConnection();
            cn = BAL.Global.seConnecter(BAL.Global.cs);
            BAL.Global.ExecuterOleDbAction(@"delete from Client where  NumClient= " + ch, cn);
            BAL.Global.seDeconnecter(cn);
        }





        public void getClientbyId(DAL.Client dl, string id)
        {
            id = "'" + id + "'";

            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lect;
            cn = BAL.Global.seConnecter(BAL.Global.cs);
            lect = BAL.Global.ExecuterOleDBSelect(@"select * from Client where NumClient=" + id, cn);
            while (lect.Read())
            {
                dl.NumClient = Int32.Parse(lect.GetValue(0).ToString());
                dl.NomClient = lect.GetValue(1).ToString();
                dl.Rue = lect.GetValue(2).ToString();
                dl.Ville = lect.GetValue(3).ToString();
                dl.CP = Int32.Parse(lect.GetValue(4).ToString());
                dl.Tel = Int32.Parse(lect.GetValue(5).ToString());
            }

            BAL.Global.seDeconnecter(cn);
            lect.Close();

        }





    }
}
