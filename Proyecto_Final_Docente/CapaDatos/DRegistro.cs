using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
  public class DRegistro
  {
    public URegistro datos(int id)
    {
      URegistro user = null;
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_I_listarDatosExtras";
          cmd.Parameters.AddWithValue("@id", id);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            if (dr.Read())
            {
              user = new URegistro(
                  dr["sexo"].ToString(),
                  dr["estadoCivil"].ToString(),
                  dr["direccion"].ToString(),
                  dr["ubigeo"].ToString(),
                  dr["dpto"].ToString(),
                  dr["prov"].ToString(),
                  dr["distrito"].ToString(),
                  dr["telefono"].ToString(),
                  dr["celular"].ToString(),
                  dr["foto"].ToString(),
                  dr["fNacimiento"].ToString(),
                  double.Parse(dr["precio_Hora"].ToString())
              );
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
      return user;
    }
    public List<UDiscapacidad> listaDisc(int id)
    {
      List<UDiscapacidad> lista = new List<UDiscapacidad>();
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_I_listarDiscapacidades";
          cmd.Parameters.AddWithValue("@id", id);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            while (dr.Read())
            {
              lista.Add(new UDiscapacidad(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3)));
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
