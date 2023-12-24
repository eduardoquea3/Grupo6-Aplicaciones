using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

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
                  int.Parse(dr["doc"].ToString()),
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
  }
}
