using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ControlPatrimonial
{
    public partial class FormAAmbientes : Form
    {
        Conexion con = new Conexion();
        int id;
        bool editar = false;
        string codigo_ambiente;

        public FormAAmbientes()
        {
            InitializeComponent();
            //Grid1.DataSource = usr.MostrarUsuarios();
            con.ActualizarGrid(this.Grid1, "Select A.Codigo_Ambientes, A.Nombre, A.Codigo_Usuario, U.Nombres, U.Apellido_Paterno, U.Apellido_Materno, count(B.Codigo) as Numero_De_Bienes from(Ambientes A left outer join Usuarios U on A.Codigo_Usuario = U.Codigo_Usuario) left outer join Bienes B on A.Codigo_Ambientes = B.Codigo_Ambiente group by A.Codigo_Ambientes, A.Nombre, A.Codigo_Usuario, U.Nombres, U.Apellido_Paterno, U.Apellido_Materno");
            checkBox.Checked = true;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BoxRespuesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxValorActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BoxTiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BoxTasaInteres_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarUsuario(object sender, EventArgs e)
        {
            if (editar)
            {
                con.Conectar();
                string consulta1 = "update Ambientes set Codigo_Ambientes='" + BoxNombres.Text + "',Nombre='" + BoxAPaterno.Text + "',Codigo_Usuario='" + BoxAMaterno.Text + "' where Codigo_Ambientes ='" + codigo_ambiente + "'";
                con.EjecutarSQL(consulta1);
                string consulta2 = "update Bienes set Codigo_Ambientes='" + BoxNombres.Text + "' where Codigo_Ambientes ='" + codigo_ambiente + "'";
                con.EjecutarSQL(consulta2);
                con.ActualizarGrid(this.Grid1, "Select A.Codigo_Ambientes, A.Nombre, A.Codigo_Usuario, U.Nombres, U.Apellido_Paterno, U.Apellido_Materno, count(B.Codigo) as Numero_De_Bienes from(Ambientes A left outer join Usuarios U on A.Codigo_Usuario = U.Codigo_Usuario) left outer join Bienes B on A.Codigo_Ambientes = B.Codigo_Ambiente group by A.Codigo_Ambientes, A.Nombre, A.Codigo_Usuario, U.Nombres, U.Apellido_Paterno, U.Apellido_Materno");
                con.Desconectar();
                editar = false;
                checkBox.Checked = true;

            }
            else
            {
                con.Conectar();
                string consulta = "insert into Ambientes values ('" + BoxNombres.Text + "','" + BoxAPaterno.Text + "','" + BoxAMaterno.Text + "')";
                con.EjecutarSQL(consulta);
                BoxNombres.Clear();
                BoxAPaterno.Clear();
                BoxAMaterno.Clear();
                con.ActualizarGrid(this.Grid1, "Select A.Codigo_Ambientes, A.Nombre, A.Codigo_Usuario, U.Nombres, U.Apellido_Paterno, U.Apellido_Materno, count(B.Codigo) as Numero_De_Bienes from(Ambientes A left outer join Usuarios U on A.Codigo_Usuario = U.Codigo_Usuario) left outer join Bienes B on A.Codigo_Ambientes = B.Codigo_Ambiente group by A.Codigo_Ambientes, A.Nombre, A.Codigo_Usuario, U.Nombres, U.Apellido_Paterno, U.Apellido_Materno");
                con.Desconectar();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            editar = true;
            checkBox.Checked = false;
            id = int.Parse(this.Grid1.CurrentRow.Cells[0].Value.ToString());
            BoxNombres.Text = this.Grid1.CurrentRow.Cells[1].Value.ToString();
            BoxAPaterno.Text = this.Grid1.CurrentRow.Cells[2].Value.ToString();
            BoxAMaterno.Text = this.Grid1.CurrentRow.Cells[3].Value.ToString();
        }

        private void BoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string consulta = "select * from Bienes where Codigo_Ambiente = '" + BoxBuscar.Text + "'";
        }
        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            id = int.Parse(this.Grid1.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("¿Desea eliminar al usuario?", "Confirme la eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from Usuarios where idUsuario='" + id + "';";
                con.EjecutarSQL(consulta);
                con.ActualizarGrid(this.Grid1, "Select * from Usuarios");
                con.Desconectar();
            }
            else
            {
                return;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                editar = false;
                BoxNombres.Clear();
                BoxAPaterno.Clear();
                BoxAMaterno.Clear();
            }
            else
            {
                editar = true;
            }
        }

        private void FormAAmbientes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.ActualizarGrid(this.Grid1, "Select * from Bienes where Codigo_Ambiente = '" + BoxBuscar.Text + "'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.ActualizarGrid(this.Grid1, "Select A.Codigo_Ambientes, A.Nombre, A.Codigo_Usuario, U.Nombres, U.Apellido_Paterno, U.Apellido_Materno, count(B.Codigo) as Numero_De_Bienes from(Ambientes A left outer join Usuarios U on A.Codigo_Usuario = U.Codigo_Usuario) left outer join Bienes B on A.Codigo_Ambientes = B.Codigo_Ambiente group by A.Codigo_Ambientes, A.Nombre, A.Codigo_Usuario, U.Nombres, U.Apellido_Paterno, U.Apellido_Materno");
        }

        private void BoxAPaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            editar = true;
            checkBox.Checked = false;
            codigo_ambiente = this.Grid1.CurrentRow.Cells[0].Value.ToString();
            //id = int.Parse(this.Grid1.CurrentRow.Cells[0].Value.ToString());
            BoxNombres.Text = this.Grid1.CurrentRow.Cells[0].Value.ToString();
            BoxAPaterno.Text = this.Grid1.CurrentRow.Cells[1].Value.ToString();
            BoxAMaterno.Text = this.Grid1.CurrentRow.Cells[2].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Conectar();
            string codigo = this.Grid1.CurrentRow.Cells[0].Value.ToString();
            int nroBienes = 0;

            nroBienes = Int32.Parse(this.Grid1.CurrentRow.Cells[6].Value.ToString());
            if (nroBienes != 0)
            {
                var resultado = MessageBox.Show("En este ambiente existen bienes, En caso de eliminar el ambiente se eliminaran todos los bienes ¿Desea eliminar el ambiente?", "Confirme la eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    string consulta = "delete from Bienes where Codigo_Ambiente = '" + codigo + "';";
                    con.EjecutarSQL(consulta);
                    string consulta1 = "delete from Ambientes where Codigo_Ambientes = '" + codigo + "'";
                    con.EjecutarSQL(consulta1);
                }
                else 
                {
                
                }
            }
            else
            {
                string consulta3 = "delete from Ambientes where Codigo_Ambientes = '" + codigo + "'";
                con.EjecutarSQL(consulta3);
            }
            con.ActualizarGrid(this.Grid1, "Select A.Codigo_Ambientes, A.Nombre, A.Codigo_Usuario, U.Nombres, U.Apellido_Paterno, U.Apellido_Materno, count(B.Codigo) as Numero_De_Bienes from(Ambientes A left outer join Usuarios U on A.Codigo_Usuario = U.Codigo_Usuario) left outer join Bienes B on A.Codigo_Ambientes = B.Codigo_Ambiente group by A.Codigo_Ambientes, A.Nombre, A.Codigo_Usuario, U.Nombres, U.Apellido_Paterno, U.Apellido_Materno");
            con.Desconectar();
            editar = false;
            checkBox.Checked = true;
        }
    }
}