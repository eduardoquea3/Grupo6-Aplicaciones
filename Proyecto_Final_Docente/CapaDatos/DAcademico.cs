using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
                dr.GetDateTime(4).ToString("dd-MM-yyyy"),
                dr.GetString(5)
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
    public void agregarA(EAcademico a)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_A_agregarDatos";
          cmd.Parameters.AddWithValue("@id", a.id);
          cmd.Parameters.AddWithValue("@titulo", a.titulo);
          cmd.Parameters.AddWithValue("@insti", a.centro);
          cmd.Parameters.AddWithValue("@fecha", a.fGrado);
          cmd.Parameters.AddWithValue("@pdf", a.pdf);
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
    public void eliminarA(int id, int idA)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_A_eliminarDatos";
          cmd.Parameters.AddWithValue("@id", id);
          cmd.Parameters.AddWithValue("@idA", idA);
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
    public EAcademico obtener(int id, int idE)
    {
      EAcademico user = null;
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_A_obtener";
          cmd.Parameters.AddWithValue("@id", id);
          cmd.Parameters.AddWithValue("@idA", idE);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            if (dr.Read())
            {
              user = new EAcademico(
                dr.GetInt32(1),
                dr.GetInt32(0),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDateTime(4).ToString(),
                dr.GetString(5)
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
    public void actualizar(EAcademico a)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_A_actualizar";
          cmd.Parameters.AddWithValue("@id", a.id);
          cmd.Parameters.AddWithValue("@idA", a.idA);
          cmd.Parameters.AddWithValue("@fg", a.fGrado);
          cmd.Parameters.AddWithValue("@centro", a.centro);
          cmd.Parameters.AddWithValue("@titulo", a.titulo);
          cmd.Parameters.AddWithValue("@pdf", a.pdf);
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
