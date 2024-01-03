using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
  public class DExperiencia
  {
    public List<EExperiencia> datos(int id)
    {
      List<EExperiencia> lista = new List<EExperiencia>();
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_I_listarExperiencias";
          cmd.Parameters.AddWithValue("@id", id);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            while (dr.Read())
            {
              lista.Add(new EExperiencia(
                dr.GetInt32(0),
                dr.GetInt32(1),
                dr.GetString(3),
                dr.GetString(2),
                dr[4].ToString().Substring(0, 10),
                dr[5].ToString().Substring(0, 10)
                ));
            }
          }
        }
        catch (Exception ex)
        {
          throw new Exception(ex.Message);
        }
        finally
        {
          cn.Dispose();
        }
      }
      return lista;
    }
  }
}
