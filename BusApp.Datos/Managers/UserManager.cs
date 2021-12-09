using BusApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BusApp.Data.Managers
{
    public class UserManager : WrapperManager
    {
        public UserManager(string command) : base(command)
        {
        }

        public List<User> Get()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(CommandDetail, conn) { CommandType = CommandType.StoredProcedure })
                {
                    conn.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CODE", "");
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        users.Add(new User()
                        {
                            UserId = int.Parse(dr["UserId"].ToString().Trim()),
                            PersonId = int.Parse(dr["PersonId"].ToString().Trim()),
                            UserName = dr["UserName"].ToString().Trim(),
                            UPassword = dr["UPassword"].ToString().Trim(),
                            Ctrl_F_Inserted = DateTime.Parse(dr["Ctrl_F_Inserted"].ToString().Trim()),
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return users;
        }

        public List<User> Get(string code)
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(CommandDetail, conn) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CODE", code);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        users.Add(new User()
                        {
                            UserId = int.Parse(dr["UserId"].ToString().Trim()),
                            PersonId = int.Parse(dr["PersonId"].ToString().Trim()),
                            UserName = dr["UserName"].ToString().Trim(),
                            UPassword = dr["UPassword"].ToString().Trim(),
                            Ctrl_F_Inserted = DateTime.Parse(dr["Ctrl_F_Inserted"].ToString().Trim()),
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return users;
        }

        public void Put(int opt, User user)
        {
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(CommandDetail, conn) { CommandType = CommandType.StoredProcedure })
                {
                    conn.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Id", user.UserId);
                    cmd.Parameters.AddWithValue("PersonId", user.PersonId);
                    cmd.Parameters.AddWithValue("UserName", user.UserName);
                    cmd.Parameters.AddWithValue("UPassword", user.UPassword);
                    cmd.Parameters.AddWithValue("@OPT", opt);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
