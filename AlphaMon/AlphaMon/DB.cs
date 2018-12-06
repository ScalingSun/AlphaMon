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

        public Account LoginFunction(string UserName, string Password)
        {
            DB login = new DB();
            using (SqlCommand LOGIN = new SqlCommand("SELECT * FROM Account WHERE @UserName = UserName AND @Password = Password", conn))
            {
                conn.Open();
                LOGIN.Parameters.Add(new SqlParameter("UserName", UserName));
                LOGIN.Parameters.Add(new SqlParameter("Password", Password));
                SqlDataReader reader = LOGIN.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }
                List<Account> UserData = new List<Account>();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string username = reader.GetString(1);
                    string password = reader.GetString(2);

                    return new Account(id, username, password);
                }
                return null;
            }
        }
    }
}
