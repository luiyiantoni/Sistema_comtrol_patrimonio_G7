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
    public class Conexion
    {
        SqlConnection con;

        public void Conectar()
        {
            con = new SqlConnection("Data Source=LAPTOP-F6BEM0H6; Initial Catalog=ControlPatrimonial; Integrated Security=True");
            con.Open();
        }
        public void Desconectar()
        {
            con.Close();
        }
        public SqlConnection LeerCadena()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }
        public void EjecutarSQL(String Consulta)
        {
            SqlCommand com = new SqlCommand(Consulta, con);
            int FilasAfectadas = com.ExecuteNonQuery();
            if (FilasAfectadas > 0)
            {
                MessageBox.Show("La operacion ha sido realizada correctamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la oepracion", "ERROR DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool VerificarExisteDatoSQL(String Consulta)
        {
            SqlCommand com = new SqlCommand(Consulta, con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
                return true;
            else
                return false;     
        }

        public List<string> ObtenerValoresLista(String Consulta)
        {
            SqlCommand com = new SqlCommand(Consulta, con);
            SqlDataReader dre = com.ExecuteReader();
            List<string> resultado = new List<string>(dre.FieldCount);
            if (dre.HasRows)
            {
                while (dre.Read())
                {
                    for (int j = 0; j < dre.FieldCount; j++)
                    {
                        resultado.Add(dre.GetSqlValue(j).ToString());
                    }
                    
                }
            }
            return resultado;
        }

    public void ActualizarGrid(DataGridView dg, string consulta)
        {
            this.Conectar();
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlDataAdapter da = new SqlDataAdapter(consulta,con);
            da.Fill(ds, "Usuarios");
            dg.DataSource = ds;
            dg.DataMember = "Usuarios";
            this.Desconectar();
        }
        public void ActualizarGridBienes(DataGridView dg, string consulta)
        {
            this.Conectar();
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(ds, "Bienes");
            dg.DataSource = ds;
            dg.DataMember = "Bienes";
            this.Desconectar();
        }

    }
}
