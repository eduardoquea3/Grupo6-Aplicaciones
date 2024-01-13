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
    public List<EUbigeo> departamento()
    {
      List<EUbigeo> lista = new List<EUbigeo>();
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_listarDpto";
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            while (dr.Read())
            {
              lista.Add(new EUbigeo(dr.GetString(0)));
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
      return lista;
    }
    public List<EUbigeo> provincia(string dpto)
    {
      List<EUbigeo> lista = new List<EUbigeo>();
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_listarProv";
          cmd.Parameters.AddWithValue("@dpto", dpto);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            while (dr.Read())
            {
              lista.Add(new EUbigeo(dr.GetString(0)));
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
      return lista;
    }
    public List<EUbigeo> distrito(string dpto, string prov)
    {
      List<EUbigeo> lista = new List<EUbigeo>();
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_listarDist";
          cmd.Parameters.AddWithValue("@dpto", dpto);
          cmd.Parameters.AddWithValue("@prov", prov);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            while (dr.Read())
            {
              lista.Add(new EUbigeo(dr.GetString(0)));
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
      return lista;
    }
    public List<ESexo> listarSexo()
    {
      List<ESexo> lista = new List<ESexo>();
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_listarSexo";
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            while (dr.Read())
            {
              lista.Add(new ESexo(dr.GetInt32(0), dr.GetString(1)));
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
      return lista;
    }
    public List<ECivil> listarCivil()
    {
      List<ECivil> lista = new List<ECivil>();
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_listarCivil";
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            while (dr.Read())
            {
              lista.Add(new ECivil(dr.GetInt32(0), dr.GetString(1)));
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
      return lista;
    }
    public List<UDiscapacidad> listarDisc(int id)
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
      return lista;
    }
    public void agregarDisc(UDiscapacidad dic)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        try
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_agregarDiscapacidad";
          cmd.Parameters.AddWithValue("@id", dic.id);
          cmd.Parameters.AddWithValue("@nombre", dic.discapacidad);
          cmd.Parameters.AddWithValue("@descripcion", dic.descDiscapacidad);
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
    public UDiscapacidad obtenerDisc(int id, int idD)
    {
      UDiscapacidad user = null;
      using (SqlConnection cn = new Conection().conectar())
      {
        SqlCommand cmd = new SqlCommand();
        try
        {
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_obtenerDiscapacidad";
          cmd.Parameters.AddWithValue("@id", id);
          cmd.Parameters.AddWithValue("@idD", idD);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            if (dr.Read())
            {
              user = new UDiscapacidad(
                dr.GetString(2), dr.GetString(3)
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
    public void eliminarDisc(int id, int idD)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        try
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_eliminarDiscapacidad";
          cmd.Parameters.AddWithValue("@id", id);
          cmd.Parameters.AddWithValue("@idD", idD);
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
    public void updateDisc(UDiscapacidad dic)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        try
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_actualizarDiscapacidad";
          cmd.Parameters.AddWithValue("@id", dic.id);
          cmd.Parameters.AddWithValue("@idD", dic.idDiscapacidad);
          cmd.Parameters.AddWithValue("@dis", dic.discapacidad);
          cmd.Parameters.AddWithValue("@descrip", dic.descDiscapacidad);
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
    public void actualizarDatosLogin(ULogin us)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        try
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_actualizarDatosUsuario";
          cmd.Parameters.AddWithValue("@id", us.id);
          cmd.Parameters.AddWithValue("@username", us.username);
          cmd.Parameters.AddWithValue("@correo", us.correo);
          cmd.Parameters.AddWithValue("@nombre", us.nombre);
          cmd.Parameters.AddWithValue("@apeP", us.apellidoPat);
          cmd.Parameters.AddWithValue("@apeM", us.apellidoMat);
          cmd.Parameters.AddWithValue("@tipo", us.tipo);
          cmd.Parameters.AddWithValue("@doc", us.documento);
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
    public void ingresarDatosR(URegistro us)
    {
      using (SqlConnection cn = new Conection().conectar())
      {
        try
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_ingresarDatos";
          cmd.Parameters.AddWithValue("@id", us.id);
          cmd.Parameters.AddWithValue("@sex", us.tipoSexo);
          cmd.Parameters.AddWithValue("@civil", us.tipoCivil);
          cmd.Parameters.AddWithValue("@direc", us.direccion);
          cmd.Parameters.AddWithValue("@ubigeo", us.ubigeo);
          cmd.Parameters.AddWithValue("@telefono", us.telefono);
          cmd.Parameters.AddWithValue("@celular", us.celular);
          cmd.Parameters.AddWithValue("@foto", us.foto);
          cmd.Parameters.AddWithValue("@fNac", us.fNac);
          cmd.Parameters.AddWithValue("@precio", us.precio);
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
    public string obtenerUbigeo(EUbigeo us)
    {
      string r = null;
      using (SqlConnection cn = new Conection().conectar())
      {
        try
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_obtenerUbigeo";
          cmd.Parameters.AddWithValue("@dpto", us.dpto);
          cmd.Parameters.AddWithValue("@prov", us.prov);
          cmd.Parameters.AddWithValue("@dist", us.dist);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            if (dr.Read())
            {
              r = dr.GetString(0);
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
    public bool validarData(string doc, string correo)
    {
      bool r = true;
      using (SqlConnection cn = new Conection().conectar())
      {
        try
        {
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_R_verificarData";
          cmd.Parameters.AddWithValue("@doc", doc);
          cmd.Parameters.AddWithValue("@correo", correo);
          cn.Open();
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
            if (dr.HasRows)
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
  }
}
