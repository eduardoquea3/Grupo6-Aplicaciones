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
                dr[5].ToString().Substring(0, 10),
                dr.GetString(6)
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
    public void agregarE(EExperiencia a)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_E_agregarExperiencia";
          cmd.Parameters.AddWithValue("@id", a.id);
          cmd.Parameters.AddWithValue("@fI", a.fInicio);
          cmd.Parameters.AddWithValue("@fF", a.fFin);
          cmd.Parameters.AddWithValue("@cargo", a.cargo);
          cmd.Parameters.AddWithValue("@empresa", a.empresa);
          cmd.Parameters.AddWithValue("@certi", a.certificado);
          cn.Open();
          cmd.ExecuteNonQuery();
          cn.Close();
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
    }
    public void eliminarE(int id, int idE)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_E_eliminarExperiencia";
          cmd.Parameters.AddWithValue("@id", id);
          cmd.Parameters.AddWithValue("@idE", idE);
          cn.Open();
          cmd.ExecuteNonQuery();
          cn.Close();
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
    }
    public EExperiencia obtener(int id, int idE)
    {
      EExperiencia user = null;
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_E_obtener";
          cmd.Parameters.AddWithValue("@id", id);
          cmd.Parameters.AddWithValue("@idE", idE);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            if (dr.Read())
            {
              user = new EExperiencia(
                dr.GetInt32(1),
                dr.GetInt32(0),
                dr.GetString(4),
                dr.GetString(5),
                dr.GetDateTime(2).ToString(),
                dr.GetDateTime(3).ToString(),
                dr.GetString(6)
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
    public void actualizar(EExperiencia a)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_E_actualizar";
          cmd.Parameters.AddWithValue("@id", a.id);
          cmd.Parameters.AddWithValue("@idE", a.idE);
          cmd.Parameters.AddWithValue("@fi", a.fInicio);
          cmd.Parameters.AddWithValue("@ff", a.fFin);
          cmd.Parameters.AddWithValue("@cargo", a.cargo);
          cmd.Parameters.AddWithValue("@emp", a.empresa);
          cmd.Parameters.AddWithValue("@certi", a.certificado);
          cn.Open();
          cmd.ExecuteNonQuery();
          cn.Close();
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
    }
  }
}
