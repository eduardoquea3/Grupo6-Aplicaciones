using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
  public class DInicio
  {
    public ULogin mostrarUsuario(int id)
    {
      ULogin user = null;
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();

        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_I_listarUsuario";
          cmd.Parameters.AddWithValue("@id", id);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            if (dr.Read())
            {
              user = new ULogin(
                  dr["nombre"].ToString(),
                  dr["apeP"].ToString(),
                  dr["apeM"].ToString(),
                  dr["username"].ToString(),
                  dr["tipo"].ToString(),
                  dr["doc"].ToString(),
                  dr["correo"].ToString()
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
    public void registro(int id)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "sp_registro";
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
      }
    }
    public void newpass(int id, string pass, string newpass)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();

        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_newPassword";
          cmd.Parameters.AddWithValue("@id", id);
          cmd.Parameters.AddWithValue("@contra", pass);
          cmd.Parameters.AddWithValue("@new", newpass);
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
