using BusApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Data.Managers
{
    public class RutaMarcadaManager : WrapperManager
    {
        public RutaMarcadaManager(string command) : base(command)
        {
        }

        public List<RutaMarcada> Get()
        {
            List<RutaMarcada> rutas = new List<RutaMarcada>();
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
                        rutas.Add(new RutaMarcada()
                        {
                            RUTA_ID = int.Parse(dr["RUTA_MARCADA_ID"].ToString().Trim()),
                            RUTA_COD = dr["RUTA_COD"].ToString().Trim(),
                            COODENADAS_INICIO = dr["COODENADAS_INICIO"].ToString().Trim(),
                            COORDENADAS_FIN = dr["COORDENADAS_FIN"].ToString().Trim(),
                            RUTA_MARCADA_ID = int.Parse(dr["RUTA_MARCADA_ID"].ToString().Trim()),
                            RUTA_MARCADA_COD    = dr["RUTA_MARCADA_COD"].ToString().Trim(),
                            Conductor_COD  = dr["Conductor_COD"].ToString().Trim(),
                            ConductorNombre = dr["ConductorNombre"].ToString().Trim(),
                            Autobus_COD = dr["Autobus_COD"].ToString().Trim(),
                            UserId  = int.Parse(dr["UserId"].ToString().Trim()),
                            //Activo = bool.Parse(dr["Activo"].ToString().Trim()),
                            Ctrl_F_Inserted = DateTime.Parse(dr["Ctrl_F_Inserted"].ToString().Trim())
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return rutas;
        }

        public List<RutaMarcada> Get(string code)
        {
            List<RutaMarcada> rutas = new List<RutaMarcada>();
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
                        rutas.Add(new RutaMarcada()
                        {
                            RUTA_ID = int.Parse(dr["RUTA_MARCADA_ID"].ToString().Trim()),
                            RUTA_COD = dr["RUTA_COD"].ToString().Trim(),
                            COODENADAS_INICIO = dr["COODENADAS_INICIO"].ToString().Trim(),
                            COORDENADAS_FIN = dr["COORDENADAS_FIN"].ToString().Trim(),
                            RUTA_MARCADA_ID = int.Parse(dr["RUTA_MARCADA_ID"].ToString().Trim()),
                            RUTA_MARCADA_COD = dr["RUTA_MARCADA_COD"].ToString().Trim(),
                            Conductor_COD = dr["Conductor_COD"].ToString().Trim(),
                            ConductorNombre = dr["ConductorNombre"].ToString().Trim(),
                            Autobus_COD = dr["Autobus_COD"].ToString().Trim(),
                            UserId = int.Parse(dr["UserId"].ToString().Trim()),
                            //Activo = bool.Parse(dr["Activo"].ToString().Trim()),
                            Ctrl_F_Inserted = DateTime.Parse(dr["Ctrl_F_Inserted"].ToString().Trim())
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return rutas;
        }

        public void Put(int opt, RutaMarcada ruta)
        {
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(CommandDetail, conn) { CommandType = CommandType.StoredProcedure })
                {
                    conn.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Id", ruta.RUTA_MARCADA_ID);
                    cmd.Parameters.AddWithValue("@RutaId", ruta.RUTA_ID);
                    cmd.Parameters.AddWithValue("@BusId", ruta.AUTOBUS_ID);
                    cmd.Parameters.AddWithValue("@ConductorId", ruta.CONDUCTOR_ID);
                    cmd.Parameters.AddWithValue("@UserId", ruta.UserId);
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
