using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
  public class DCurso
  {
    public List<ECurso> listarCursos(int id)
    {
      List<ECurso> lista = new List<ECurso>();
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_C_listarCursos";
          cmd.Parameters.AddWithValue("@id", id);
          cn.Open();
          using (SqlDataReader rd = cmd.ExecuteReader())
          {
            while (rd.Read())
            {
              lista.Add(new ECurso(int.Parse(rd[0].ToString()), rd[1].ToString()));
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
