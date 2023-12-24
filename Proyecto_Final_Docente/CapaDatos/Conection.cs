using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conection
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString);
        public SqlConnection conectar()
        {
            return cn;
        }
    }
}
