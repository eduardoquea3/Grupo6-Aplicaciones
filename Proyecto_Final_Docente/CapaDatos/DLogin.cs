using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
  public class DLogin
  {
    public string agregar(ULogin user)
    {
      string r = "";
      using (SqlConnection cn = new Conection().conectar())
      {
        try
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_AgregarUsuario";
          cmd.Parameters.AddWithValue("@nombre", user.nombre);
          cmd.Parameters.AddWithValue("@apeP", user.apellidoPat);
          cmd.Parameters.AddWithValue("@apeM", user.apellidoMat);
          cmd.Parameters.AddWithValue("@username", user.username);
          cmd.Parameters.AddWithValue("@tipo", user.tipo);
          cmd.Parameters.AddWithValue("@doc", user.documento);
          cmd.Parameters.AddWithValue("@correo", user.correo);
          cmd.Parameters.AddWithValue("@contra", user.contra);
          cn.Open();
          int f = cmd.ExecuteNonQuery();
          if (f > 0)
          {
            r = "Usuario creado";
          }
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
      return r;
    }

    public bool validar(ULogin user)
    {
      bool r = true;
      using (SqlConnection cn = new Conection().conectar())
      {
        try
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_ValidarUsuario";
          cmd.Parameters.AddWithValue("@doc", user.documento);
          cmd.Parameters.AddWithValue("@correo", user.correo);
          cn.Open();
          using (SqlDataReader rd = cmd.ExecuteReader())
          {
            if (rd.HasRows)
            {
              r = false;
            }
          }
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
      return r;
    }

    public int login(ULogin user)
    {
      int id = -1;
      using (SqlConnection cn = new Conection().conectar())
      {
        try
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_Login";
          cmd.Parameters.AddWithValue("@correo", user.correo);
          cmd.Parameters.AddWithValue("@contra", user.contra);
          cn.Open();
          SqlDataReader rd = cmd.ExecuteReader();
          if (rd.Read())
          {
            id = rd.GetInt32(0);
          }
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
      return id;
    }
  }
}
