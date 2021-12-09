using BusApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BusApp.Data.Managers
{
    public class ConductorManager : WrapperManager
    {
        public ConductorManager(string command) : base(command)
        {
        }

        public List<ConductorPersona> Get()
        {
            List<ConductorPersona> conductores = new List<ConductorPersona>();
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
                        conductores.Add(new ConductorPersona()
                        {
                            PersonCOD = dr["PersonCOD"].ToString().Trim(),
                            Conductor_COD = dr["Conductor_COD"].ToString().Trim(),
                            Cedula = dr["Cedula"].ToString().Trim(),
                            Nombre = dr["Nombre"].ToString().Trim(),
                            Apellido = dr["Apellido"].ToString().Trim(),
                            Fecha_de_nacimiento = DateTime.Parse(dr["Fecha_de_nacimiento"].ToString().Trim()),
                            Activo = bool.Parse(dr["Activo"].ToString().Trim()),
                            Ctrl_F_Inserted = DateTime.Parse(dr["Ctrl_F_Inserted"].ToString().Trim())
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return conductores;
        }

        public List<ConductorPersona> Get(string code)
        {
            List<ConductorPersona> conductores = new List<ConductorPersona>();
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(CommandDetail, conn) { CommandType = CommandType.StoredProcedure })
                {
                    conn.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CODE", code);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        conductores.Add(new ConductorPersona()
                        {
                            PersonCOD = dr["PersonCOD"].ToString().Trim(),
                            Conductor_COD = dr["Conductor_COD"].ToString().Trim(),
                            Cedula = dr["Cedula"].ToString().Trim(),
                            Nombre = dr["Nombre"].ToString().Trim(),
                            Apellido = dr["Apellido"].ToString().Trim(),
                            Fecha_de_nacimiento = DateTime.Parse(dr["Fecha_de_nacimiento"].ToString().Trim()),
                            Activo = bool.Parse(dr["Activo"].ToString().Trim()),
                            Ctrl_F_Inserted = DateTime.Parse(dr["Ctrl_F_Inserted"].ToString().Trim())
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return conductores;
        }

        public void Put(int opt, ConductorPersona ConductorPersona)
        {
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(CommandDetail, conn) { CommandType = CommandType.StoredProcedure })
                {
                    conn.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("", 0);
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
