using BusApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BusApp.Data.Managers
{
    public class AutobusManager : WrapperManager
    {
        public AutobusManager(string command) : base(command)
        {
        }

        public List<AutoBus> Get()
        {
            List<AutoBus> buses = new List<AutoBus>();
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
                        buses.Add(new AutoBus()
                        {
                            Id_Autobus = int.Parse(dr["Id_Autobus"].ToString().Trim()),
                            BUS_CODE = dr["BUS_CODE"].ToString().Trim(),
                            Marca = dr["Marca"].ToString().Trim(),
                            Modelo = dr["Modelo"].ToString().Trim(),
                            Placa = dr["Placa"].ToString().Trim(),
                            Color = dr["Color"].ToString().Trim(),
                            Año = DateTime.Parse(dr["Año"].ToString().Trim()),
                            Activo = bool.Parse(dr["Activo"].ToString().Trim()),
                            Ctrl_F_Inserted = DateTime.Parse(dr["FechaInserted"].ToString().Trim())
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return buses;
        }

        public List<AutoBus> Get(string code)
        {
            List<AutoBus> buses = new List<AutoBus>();
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
                        buses.Add(new AutoBus()
                        {
                            Id_Autobus = int.Parse(dr[""].ToString().Trim()),
                            BUS_CODE = dr["BUS_CODE"].ToString().Trim(),
                            Marca = dr["Marca"].ToString().Trim(),
                            Modelo = dr["Modelo"].ToString().Trim(),
                            Placa = dr["Placa"].ToString().Trim(),
                            Color = dr["Color"].ToString().Trim(),
                            Año = DateTime.Parse(dr["Año"].ToString().Trim()),
                            Activo = bool.Parse(dr["Activo"].ToString().Trim()),
                            Ctrl_F_Inserted = DateTime.Parse(dr["FechaInserted"].ToString().Trim())
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return buses;
        }

        public void Put(int opt, AutoBus autoBus)
        {
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(CommandDetail, conn) { CommandType = CommandType.StoredProcedure })
                {
                    conn.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CODE", autoBus.BUS_CODE);
                    cmd.Parameters.AddWithValue("@Marca", autoBus.Marca);
                    cmd.Parameters.AddWithValue("@Modelo", autoBus.Modelo);
                    cmd.Parameters.AddWithValue("@Placa", autoBus.Placa);
                    cmd.Parameters.AddWithValue("@Color", autoBus.Color);
                    cmd.Parameters.AddWithValue("@year", autoBus.Año);
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
