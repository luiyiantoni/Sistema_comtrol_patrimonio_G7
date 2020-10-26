using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ControlPatrimonial
{
    public class Usuarios
    {
        Conexion cn = new Conexion();
        public DataTable MostrarUsuarios()
        {
            SqlDataAdapter da = new SqlDataAdapter("CP_MOSTRARUSUARIOS", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
