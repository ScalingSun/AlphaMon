using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaMon
{
    class DB
    {
        public DB()
        {
            try
            {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "alphamon.database.windows.net";
                cb.UserID = "alphamon";
                cb.Password = "Konijnenvanger648";
                cb.InitialCatalog = "Alphamon ";

                using (var connection = new SqlConnection(cb.ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
