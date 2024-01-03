using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace CapaDatos
{
  public class DAcademico
  {
    public List<EAcademico> datos(int id)
    {
      List<EAcademico> lista = new List<EAcademico>();
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_I_listarDatosAcademicos";
          cmd.Parameters.AddWithValue("@id", id);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            while (dr.Read())
            {
              lista.Add(new EAcademico(
                dr.GetInt32(0),
                dr.GetInt32(1),
                dr.GetString(2),
                dr.GetString(3),
                DateTime.ParseExact(dr[4].ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture).Date.ToString("dd/MM/yyyy")
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
