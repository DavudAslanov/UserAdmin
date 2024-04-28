using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAdmin.DataAcces.SqlDBContext
{
    public static class SQLDatabaseConnect
    {

        public static string SQlDatabase()
        {
            try
            {
                SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
                connection.InitialCatalog = "UsersAdmin";
                connection.DataSource = "Localhost";
                connection.IntegratedSecurity = true;
                connection.TrustServerCertificate = true;

                string stringconnection = connection.ConnectionString;
                return stringconnection;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Databse ile Qosulma Alinmadi:");
            }
            return null;
        }


    }






}
