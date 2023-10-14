using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace WebApplicationMVC.Business.Utils
{
    public class DBConnect
    {
        private IConfiguration _configuration = null;

        public DBConnect() 
        {
            //var builder - new ConfigurationBuilder
        }

        public const string DBConnection = "Data Source=NOTEBOOK\\SQLEXPRESS;Initial Catalog=ProjetoMVC;User ID=sa;Password=Senac@2023;";
        
        public static string GetDBConnection()
        {
            return DBConnection;
        }

        public static bool TesteConnection() 
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DBConnection))
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT COUNT(ID) FROM PRODUTOS";

                    var reader = cmd.ExecuteReader();
                    reader.Read();

                    return true;

                }
            }
            catch
            {
                return false;
            }
            
        }
    }
}
