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
    public partial class FormABienes : Form
    {
        Conexion con = new Conexion();
        int id;
        bool editar=false;

        public FormABienes()
        {
            InitializeComponent();
            //Grid1.DataSource = usr.MostrarUsuarios();
            con.ActualizarGrid(this.Grid1, "Select * from Usuarios");
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
                string consulta = "update Usuarios set Nombres='" + BoxNombres.Text + "',APaterno='" + BoxAPaterno.Text + "',AMaterno='" + BoxAMaterno.Text + "',DNI='" + BoxDNI.Text + "',Usuario='" + BoxUsuario.Text + "',Contraseña='" + BoxContraseña.Text + "'" + " where idUsuario='" + id + "'";
                con.EjecutarSQL(consulta);
                con.ActualizarGrid(this.Grid1, "Select * from Usuarios");
                con.Desconectar();
                editar = false;
                checkBox.Checked = true;
            }
            else
            {
                con.Conectar();
                string consulta = "insert into Usuarios (Nombres,APaterno,AMaterno,DNI,Usuario,Contraseña) values ('" + BoxNombres.Text + "','" + BoxAPaterno.Text + "','" + BoxAMaterno.Text + "','" + BoxDNI.Text + "','" + BoxUsuario.Text + "','" + BoxContraseña.Text + "')";
                con.EjecutarSQL(consulta);
                BoxNombres.Clear();
                BoxAPaterno.Clear();
                BoxAMaterno.Clear();
                BoxDNI.Clear();
                BoxUsuario.Clear();
                BoxContraseña.Clear();
                con.ActualizarGrid(this.Grid1, "Select * from Usuarios");
                con.Desconectar();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            editar = true;
            checkBox.Checked = false;
            id= int.Parse(this.Grid1.CurrentRow.Cells[0].Value.ToString());
            BoxNombres.Text = this.Grid1.CurrentRow.Cells[1].Value.ToString();
            BoxAPaterno.Text = this.Grid1.CurrentRow.Cells[2].Value.ToString();
            BoxAMaterno.Text = this.Grid1.CurrentRow.Cells[3].Value.ToString();
            BoxDNI.Text = this.Grid1.CurrentRow.Cells[4].Value.ToString();
            BoxUsuario.Text = this.Grid1.CurrentRow.Cells[5].Value.ToString();
            BoxContraseña.Text = this.Grid1.CurrentRow.Cells[6].Value.ToString();
        }

        private void BoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            con.ActualizarGrid(this.Grid1, "select * from Usuarios where " + comboBox1.SelectedItem.ToString() + " like'" + BoxBuscar.Text + "%';");
        }
        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            id = int.Parse(this.Grid1.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("¿Desea eliminar al usuario?","Confirme la eliminacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from Usuarios where idUsuario='"+id+"';";
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
                BoxDNI.Clear();
                BoxUsuario.Clear();
                BoxContraseña.Clear();
            }
            else 
            {
                editar = true;
            }
        }
    }
}
