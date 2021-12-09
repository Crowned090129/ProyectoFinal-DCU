using BusApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BusApp.Data.Managers
{
    public class RutaManager : WrapperManager
    {
        public RutaManager(string command) : base(command)
        {
        }

        public List<Ruta> Get()
        {
            List<Ruta> rutas = new List<Ruta>();
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
                        rutas.Add(new Ruta()
                        {
                            RUTA_ID = int.Parse(dr["RUTA_ID"].ToString().Trim()),
                            RUTA_COD = dr["RUTA_COD"].ToString().Trim(),
                            COODENADAS_INICIO = dr["COODENADAS_INICIO"].ToString().Trim(),
                            COORDENADAS_FIN = dr["COORDENADAS_FIN"].ToString().Trim(),
                            Activo = bool.Parse(dr["Activo"].ToString().Trim()),
                            Ctrl_F_Inserted = DateTime.Parse(dr["Ctrl_F_Inserted"].ToString().Trim())
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return rutas;
        }

        public List<Ruta> Get(string code)
        {
            List<Ruta> rutas = new List<Ruta>();
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
                        rutas.Add(new Ruta()
                        {
                            RUTA_ID = int.Parse(dr["RUTA_ID"].ToString().Trim()),
                            RUTA_COD = dr["RUTA_COD"].ToString().Trim(),
                            COODENADAS_INICIO = dr["COODENADAS_INICIO"].ToString().Trim(),
                            COORDENADAS_FIN = dr["COORDENADAS_FIN"].ToString().Trim(),
                            Activo = bool.Parse(dr["Activo"].ToString().Trim()),
                            Ctrl_F_Inserted = DateTime.Parse(dr["Ctrl_F_Inserted"].ToString().Trim())
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return rutas;
        }

        public void Put(int opt, Ruta ruta)
        {
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(CommandDetail, conn) { CommandType = CommandType.StoredProcedure })
                {
                    conn.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CODE", ruta.RUTA_COD);
                    cmd.Parameters.AddWithValue("@InitCoor", ruta.COODENADAS_INICIO);
                    cmd.Parameters.AddWithValue("@InitCoor", ruta.COODENADAS_INICIO);
                    cmd.Parameters.AddWithValue("@EndCoor", ruta.COORDENADAS_FIN);
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
