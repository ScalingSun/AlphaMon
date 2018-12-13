using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaMon
{
    public class DB
    {
        private string connection;

        public DB()
        {
            try
            {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "alphamon.database.windows.net";
                cb.UserID = "alphamon";
                cb.Password = "Konijnenvanger648";
                cb.InitialCatalog = "Alphamon";
                this.connection = cb.ConnectionString;

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public bool RegisterQuery(string Username, string Password)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    using (SqlCommand REGISTER = new SqlCommand("INSERT INTO Account (Username, Password, ELO, Wins, Losses) VALUES (@Username, @Password, 50, 0, 0)", conn))
                    {
                        conn.Open();
                        REGISTER.Parameters.Add(new SqlParameter("@Username", Username));
                        REGISTER.Parameters.Add(new SqlParameter("@Password", Password));
                        REGISTER.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public Account LoginFunction(string UserName, string Password)
        {
            using (SqlConnection conn = new SqlConnection(connection))
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
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        string password = reader.GetString(2);
                        int elo = reader.GetInt32(3);
                        int wins = reader.GetInt32(4);
                        int losses = reader.GetInt32(5);

                        return new Account(id, username, password, elo, wins, losses);
                    }
                    return null;
                }
            }
        }
        public AlphaMon GetAlphamon(int someID)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                DB AlphaMon = new DB();
                using (SqlCommand ALPHAMON = new SqlCommand("SELECT * FROM Alphamon WHERE @SomeID = ID", conn))
                {
                    conn.Open();
                    ALPHAMON.Parameters.Add(new SqlParameter("SomeID", someID));
                    SqlDataReader reader = ALPHAMON.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        return null;
                    }
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        int type = reader.GetInt32(2);
                        int SpDefense = reader.GetInt32(3);
                        int SpAttack = reader.GetInt32(4);
                        int Attack = reader.GetInt32(5);
                        int Defense = reader.GetInt32(6);
                        int Speed = reader.GetInt32(7);
                        int HP = reader.GetInt32(8);
                        return new AlphaMon(id, name, type, SpDefense, SpAttack, Attack, Defense, Speed, HP);
                    }
                    conn.Close();
                    return null;
                }
            }
        }
        public List <Move> GetMoves(int AlphamonID)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                DB AlphaMon = new DB();
                using (SqlCommand ALPHAMON = new SqlCommand("SELECT * FROM Moves INNER JOIN AlphamonMoves ON Moves.ID = AlphamonMoves.MovesID WHERE MonsterID = @AlphamonID", conn))
                {
                    conn.Open();
                    ALPHAMON.Parameters.Add(new SqlParameter("AlphamonID", AlphamonID));
                    SqlDataReader reader = ALPHAMON.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        return null;
                    }
                    List<Move> Returnlist = new List<Move>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        int power = reader.GetInt32(2);
                        int type = reader.GetInt32(3);
                        string description = reader.GetString(4);
                        int statusChance = reader.GetInt32(5);
                        int Status = reader.GetInt32(6);
                        Returnlist.Add(new Move(id, name, power, type, description, statusChance, Status));
                        
                    }
                    conn.Close();
                    return Returnlist;
                }
            }
        }
    }
}
