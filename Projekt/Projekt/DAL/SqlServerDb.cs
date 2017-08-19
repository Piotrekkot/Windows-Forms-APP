using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Projekt.DAL
{
    public class SqlServerDb : ClientDb
    {

        public void DeleteClient(Client ClientToDelete)
        {
            using (var sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var sqlCommand = new SqlCommand("DELETE FROM Client WHERE ClientId=@ClientId", sqlCon);
                sqlCommand.Parameters.Add("ClientId", SqlDbType.Int).Value = ClientToDelete.ClientId;
                sqlCon.Open();

                sqlCommand.ExecuteNonQuery();

            }
        }


        public IList<Client> GetClient()
        {
            
            var result = new List<Client>();
            using (var sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var sqlCommand = new SqlCommand("SELECT * FROM Client", sqlCon);
                sqlCon.Open();

                var dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    var newClient = new Client
                    {
                        ClientId = (int)dr["ClientId"],
                        Nname = dr["Name"].ToString(),
                        Ename = dr["Ename"].ToString(),
                        AddDate = dr["AddDate"].ToString(),
                        Email = dr["Email"].ToString(),
                        ClientStatus = dr["ClientStatus"].ToString(),
                        Rabat = (int)dr["Rabat"]

                    };
                    result.Add(newClient);
                }
                dr.Dispose();
            }
            return result;
        }

        public IList<Client> GetRabat()
        {
            var result = new List<Client>();
            using (var sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var sqlCommand = new SqlCommand("SELECT ClientId,Name,Ename,ClientStatus,Rabat FROM Client WHERE ClientStatus = 'Vip'", sqlCon);
                sqlCon.Open();

                var dr = sqlCommand.ExecuteReader();
               while (dr.Read())
                {
                    var newClient = new Client
                    {
                        ClientId = (int)dr["ClientId"],
                        Nname = dr["Name"].ToString(),
                        Ename = dr["Ename"].ToString(),
                        ClientStatus = dr["ClientStatus"].ToString(),
                        Rabat = (int)dr["Rabat"]

                    };
                    result.Add(newClient);
                }
                dr.Dispose();
            }
            return result;
        }

        public int UpdateClient(Client changedClient)
        {
            DateTime date;
            DateTime? date2;
            bool isdate = DateTime.TryParse(changedClient.AddDate, out date);
            if (!isdate)
            {
                date2 = null;
            }else
            {
                date2 = date;
            }
            int clientId = changedClient.ClientId;
            using (var sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var sqlCommand = new SqlCommand("AddClient", sqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("ClientId", SqlDbType.Int).Value = changedClient.ClientId;
                sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar).Value = changedClient.Nname;
                sqlCommand.Parameters.Add("Ename", SqlDbType.NVarChar).Value = changedClient.Ename;
                
                sqlCommand.Parameters.Add("AddDate", SqlDbType.DateTime).Value = date2;
                sqlCommand.Parameters.Add("Email", SqlDbType.NVarChar).Value = changedClient.Email;
                sqlCommand.Parameters.Add("ClientStatus", SqlDbType.NVarChar).Value = changedClient.ClientStatus;
                sqlCommand.Parameters.Add("Rabat", SqlDbType.NVarChar).Value = changedClient.Rabat;

                sqlCon.Open();

                var dr = sqlCommand.ExecuteReader();
                if (dr.Read())
                {
                    clientId = int.Parse(dr["ClientId"].ToString());
                }
                dr.Dispose();
            }
            return clientId;
        }
    }
}
