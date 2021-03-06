﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alphamon
{
    public class DB
    {
        private string connection;

        public DB()
        {
            try
            {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "alphamon2.database.windows.net";
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
        /// <summary>
        /// Use for listing players in the database.
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool RegisterQuery(string Username, string Password)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    using (SqlCommand REGISTER = new SqlCommand("INSERT INTO Account (Username, Password, ELO, Wins, Losses, Role) VALUES (@Username, @Password, 1000, 0, 0,0)", conn))
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
        /// <summary>
        /// Use for Logging into the game.
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// get all aplhamon data based on "int ID"
        /// </summary>
        /// <param name="someID"></param>
        /// <returns></returns>
        public Alphamon GetAlphamon(string someID)
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
                        string id = reader.GetString(0);
                        string name = reader.GetString(1);
                        int type = reader.GetInt32(2);
                        int HP = reader.GetInt32(4);
                        int Attack = reader.GetInt32(5);
                        int Defense = reader.GetInt32(6);
                        int SpAttack = reader.GetInt32(7);
                        int SpDefense = reader.GetInt32(8); 
                        int Speed = reader.GetInt32(9);
                        
                        return new Alphamon(id, name, type, SpDefense, SpAttack, Attack, Defense, Speed, HP);
                    }
                    conn.Close();
                    return null;
                }
            }
        }
        /// <summary>
        /// Gets a list of moves based on an alphamonID.
        /// </summary>
        /// <param name="AlphamonID"></param>
        /// <returns></returns>
        public List <Move> GetMoves(string AlphamonID)
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
        /// <summary>
        /// Gets the power from a move based on the moveName. 
        /// </summary>
        /// <param name="MoveName"></param>
        /// <returns></returns>
        public int getPowerFromMove(string MoveName)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                DB AlphaMon = new DB();
                using (SqlCommand ALPHAMON = new SqlCommand("SELECT Power FROM Moves WHERE Name = @MoveName", conn))
                {
                    conn.Open();
                    ALPHAMON.Parameters.Add(new SqlParameter("MoveName", MoveName));
                    SqlDataReader reader = ALPHAMON.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        return 0;
                    }
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        return id;

                    }
                    conn.Close();
                    return 0;
                }
            }
        }
    }
}
