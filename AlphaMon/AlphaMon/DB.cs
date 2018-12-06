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
        private SqlConnection conn;
        public DB()
        {
            try
            {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "alphamon.database.windows.net";
                cb.UserID = "alphamon";
                cb.Password = "Konijnenvanger648";
                cb.InitialCatalog = "Alphamon";
                SqlConnection con = new SqlConnection(cb.ConnectionString);
                this.conn = con;
                
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public bool RegisterQuery(string Username, string Password)
        {
            try
            {
                using (SqlCommand REGISTER = new SqlCommand("INSERT INTO Account (Username, Password, ELO, Wins, Losses) VALUES (@Username, @Password, 50, 0, 0)", conn))
                {
                    conn.Open();
                    REGISTER.Parameters.AddWithValue("@Username", Username);
                    REGISTER.Parameters.AddWithValue("@Password", Password);
                    REGISTER.ExecuteNonQuery();
                }

                return true;
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
