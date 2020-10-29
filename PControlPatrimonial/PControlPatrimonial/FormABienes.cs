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
        string codigobien;
        private void inicializarCabecera()
        {
            this.Grid1.Columns[0].HeaderText = "Codigo";
            this.Grid1.Columns[1].HeaderText = "Descripcion";
            this.Grid1.Columns[2].HeaderText = "Estado";
            this.Grid1.Columns[3].HeaderText = "Observacion";
            this.Grid1.Columns[4].HeaderText = "Fecha Compra";
            this.Grid1.Columns[5].HeaderText = "Valor Historico";
            this.Grid1.Columns[6].HeaderText = "Valor Neto";
            this.Grid1.Columns[7].HeaderText = "Depreciacion";
            this.Grid1.Columns[8].HeaderText = "Tiempo Vida";
        }
        private void LimpiarTexBox()
        {
            this.BoxCodigo.Clear();
            this.BoxDescripcion.Clear();
            this.BoxEstado.Clear();
            this.BoxObservacion.Clear();
            this.BoxValorH.Clear();
            this.BoxDepreciacion.Clear();
            this.BoxTVida.Clear();
            this.BoxFechaCompra.Clear();
            this.BoxValorNeto.Clear();
            this.BoxColor.Clear();
            this.BoxDimensiones.Clear();
            this.BoxDepreciacionAnual.Clear();
            this.BoxMarca.Clear();
            this.BoxModelo.Clear();
            this.BoxCaracteristicas.Clear();
            this.BoxDepreciacionMensual.Clear();
            this.BoxCodigoAmbiente.Clear();
        }
        public FormABienes()
        {
            InitializeComponent();
            con.ActualizarGrid(this.Grid1, "select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Muebles union select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Computo");
            inicializarCabecera();
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
                string consulta = "update Usuarios set Nombres='" + BoxCodigo.Text + "',APaterno='" + BoxDescripcion.Text + "',AMaterno='" + BoxColor.Text + "',DNI='" + BoxValorH.Text + "',Usuario='" + BoxObservacion.Text + "',Contraseña='" + BoxDepreciacion.Text + "'" + " where idUsuario='" + id + "'";
                con.EjecutarSQL(consulta);
                con.ActualizarGrid(this.Grid1, "Select * from Usuarios");
                con.Desconectar();
                editar = false;
                //checkBox.Checked = true;
            }
            else
            {
                con.Conectar();
                string consulta = "insert into Usuarios (Nombres,APaterno,AMaterno,DNI,Usuario,Contraseña) values ('" + BoxCodigo.Text + "','" + BoxDescripcion.Text + "','" + BoxColor.Text + "','" + BoxValorH.Text + "','" + BoxObservacion.Text + "','" + BoxDepreciacion.Text + "')";
                con.EjecutarSQL(consulta);
                BoxCodigo.Clear();
                BoxDescripcion.Clear();
                BoxColor.Clear();
                BoxValorH.Clear();
                BoxObservacion.Clear();
                BoxDepreciacion.Clear();
                con.ActualizarGrid(this.Grid1, "Select * from Usuarios");
                con.Desconectar();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            this.editar = true;
            this.RadioBMueble.Checked = false;
            this.RadioBComputo.Checked = false;
            this.LabelEstado.Text = "Editando";
            this.codigobien = this.Grid1.CurrentRow.Cells[0].Value.ToString();
            this.con.Conectar();
            if (this.con.VerificarExisteDatoSQL("SELECT Codigo FROM Muebles WHERE Codigo='" + this.codigobien + "'"))
            {
                this.con.Desconectar();
                this.con.Conectar();
                if (this.comboBox1.Text == "Ambos" || this.comboBox1.Text == "Muebles")
                {
                    this.editar = true;
                    List<string> stringList1 = new List<string>();
                    List<string> stringList2 = this.con.ObtenerValoresLista("Select * from Muebles where Codigo='" + this.codigobien + "'");
                    this.BoxCodigo.Text = this.codigobien;
                    this.BoxDescripcion.Text = stringList2[1];
                    this.BoxEstado.Text = stringList2[2];
                    this.BoxColor.Text = stringList2[3];
                    this.BoxDimensiones.Text = stringList2[4];
                    this.BoxObservacion.Text = stringList2[5];
                    this.BoxValorH.Text = stringList2[6];
                    this.BoxDepreciacion.Text = stringList2[7];
                    this.BoxValorNeto.Text = stringList2[8];
                    this.BoxFechaCompra.Text = stringList2[9];
                    this.BoxDepreciacionAnual.Text = stringList2[10];
                    this.BoxTVida.Text = stringList2[11];
                    this.BoxMarca.Clear();
                    this.BoxCaracteristicas.Clear();
                    this.BoxModelo.Clear();
                    this.BoxDepreciacionMensual.Clear();
                }
            }
            else
            {
                this.con.Desconectar();
                this.con.Conectar();
                if (this.comboBox1.Text == "Ambos" || this.comboBox1.Text == "Computo")
                {
                    this.editar = true;
                    List<string> stringList1 = new List<string>();
                    List<string> stringList2 = this.con.ObtenerValoresLista("Select * from Computo where Codigo='" + this.codigobien + "'");
                    this.BoxCodigo.Text = this.codigobien;
                    this.BoxDescripcion.Text = stringList2[1];
                    this.BoxMarca.Text = stringList2[2];
                    this.BoxModelo.Text = stringList2[3];
                    this.BoxCaracteristicas.Text = stringList2[4];
                    this.BoxEstado.Text = stringList2[5];
                    this.BoxObservacion.Text = stringList2[6];
                    this.BoxValorH.Text = stringList2[7];
                    this.BoxDepreciacion.Text = stringList2[8];
                    this.BoxValorNeto.Text = stringList2[9];
                    this.BoxFechaCompra.Text = stringList2[10];
                    this.BoxDepreciacionMensual.Text = stringList2[11];
                    this.BoxTVida.Text = stringList2[12];
                    this.BoxColor.Clear();
                    this.BoxDimensiones.Clear();
                    this.BoxDepreciacionAnual.Clear();
                }
            }
            this.con.Desconectar();
        }

        private void BoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            this.con.ActualizarGrid(this.Grid1, " select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida into #t1 from Muebles union select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Computo; select * from #t1 where " + comboBox2.SelectedItem.ToString() + " like'" + BoxBuscar.Text + "%';drop table #t1;");
        }
        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            con.Conectar();
            codigobien = Grid1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el bien seleccionado?", "Confirme la eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (con.VerificarExisteDatoSQL("SELECT Codigo FROM Muebles WHERE Codigo='" + this.codigobien + "'"))
                {
                    con.Desconectar();
                    con.Conectar();
                    con.EjecutarSQL("delete from Muebles where Codigo='" + codigobien + "';delete from bienes where Codigo='" + codigobien + "';");
                    con.ActualizarGrid(Grid1, "Select * from Muebles");
                    con.Desconectar();
                }
                else
                {
                    con.Desconectar();
                    con.Conectar();
                    con.EjecutarSQL("delete from Computo where Codigo='" + codigobien + "';delete from bienes where Codigo='" + codigobien + "';");
                    con.ActualizarGrid(Grid1, "Select * from Computo");
                    con.Desconectar();
                }
            }
            else
                con.Desconectar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "Computo")
                this.con.ActualizarGrid(this.Grid1, "select * from Computo");
            if (this.comboBox1.Text == "Muebles")
                this.con.ActualizarGrid(this.Grid1, "select * from Muebles");
            if (!(this.comboBox1.Text == "Ambos"))
                return;
            this.con.ActualizarGrid(this.Grid1, "select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Muebles union select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Computo");
        }

        private void RadioBComputo_CheckedChanged(object sender, EventArgs e)
        {
            this.editar = false;
            this.LabelEstado.Text = "Agregando";
            this.LimpiarTexBox();
        }

        private void RadioBMueble_CheckedChanged(object sender, EventArgs e)
        {
            this.editar = false;
            this.LabelEstado.Text = "Agregando";
            this.LimpiarTexBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.editar)
            {
                this.codigobien = this.Grid1.CurrentRow.Cells[0].Value.ToString();
                this.con.Conectar();
                if (this.con.VerificarExisteDatoSQL("SELECT Codigo FROM Muebles WHERE Codigo='" + this.codigobien + "'"))
                {
                    this.con.Desconectar();
                    this.con.Conectar();
                    this.con.EjecutarSQL("update Muebles set Codigo ='" + this.BoxCodigo.Text + "',Descripcion='" + this.BoxDescripcion.Text + "',Estado='" + this.BoxEstado.Text + "',Color='" + this.BoxColor.Text + "',Dimensiones='" + this.BoxDimensiones.Text + "',Observacion='" + this.BoxObservacion.Text + "',Valor_Historico='" + this.BoxValorH.Text + "',Depreciacion='" + this.BoxDepreciacion.Text + "',Valor_Neto='" + this.BoxValorNeto.Text + "',Fecha_Compra='" + this.BoxFechaCompra.Text + "',Depreciacion_Anual='" + this.BoxDepreciacionAnual.Text + "',Tiempo_Vida='" + this.BoxTVida.Text + "' where Codigo='" + this.codigobien + "';update Bienes set Codigo ='" + this.BoxCodigo.Text + "' where Codigo = '" + this.codigobien + "';");
                    this.con.ActualizarGrid(this.Grid1, "select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Muebles union select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Computo");
                    this.con.Desconectar();
                    this.editar = false;
                }
                else
                {
                    this.con.Desconectar();
                    this.con.Conectar();
                    this.con.EjecutarSQL("update Computo set Codigo ='" + this.BoxCodigo.Text + "',Descripcion='" + this.BoxDescripcion.Text + "',Marca='" + this.BoxMarca.Text + "',Modelo='" + this.BoxModelo.Text + "',Caracteristicas='" + this.BoxCaracteristicas.Text + "',Estado='" + this.BoxEstado.Text + "',Observacion='" + this.BoxObservacion.Text + "',Valor_Historico='" + this.BoxValorH.Text + "',Depreciacion='" + this.BoxDepreciacion.Text + "',Valor_Neto='" + this.BoxValorNeto.Text + "',Fecha_Compra='" + this.BoxFechaCompra.Text + "',Depreciacion_Mensual='" + this.BoxDepreciacionMensual.Text + "',Tiempo_Vida='" + this.BoxTVida.Text + "' where Codigo='" + this.codigobien + "';update Bienes set Codigo ='" + this.BoxCodigo.Text + "' where Codigo = '" + this.codigobien + "';");
                    this.con.ActualizarGrid(this.Grid1, "select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Muebles union select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Computo");
                    this.con.Desconectar();
                    this.editar = false;
                }
            }
            else if (this.RadioBMueble.Checked)
            {
                this.con.Conectar();
                this.con.EjecutarSQL("insert into Muebles values ('" + this.BoxCodigo.Text + "','" + this.BoxDescripcion.Text + "','" + this.BoxEstado.Text + "','" + this.BoxColor.Text + "','" + this.BoxDimensiones.Text + "','" + this.BoxObservacion.Text + "'," + this.BoxValorH.Text + "," + this.BoxDepreciacion.Text + "," + this.BoxValorNeto.Text + ",'" + this.BoxFechaCompra.Text + "'," + this.BoxDepreciacionAnual.Text + "," + this.BoxTVida.Text + ");insert into Bienes values ('" + this.BoxCodigo.Text + "','2','" + this.BoxCodigoAmbiente.Text + "')");
                this.con.ActualizarGrid(this.Grid1, "select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Muebles union select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Computo");
                this.con.Desconectar();
            }
            else if (this.RadioBComputo.Checked)
            {
                this.con.Conectar();
                this.con.EjecutarSQL("insert into Computo values ('" + this.BoxCodigo.Text + "','" + this.BoxDescripcion.Text + "','" + this.BoxMarca.Text + "','" + this.BoxModelo.Text + "','" + this.BoxCaracteristicas.Text + "','" + this.BoxEstado.Text + "','" + this.BoxObservacion.Text + "'," + this.BoxValorH.Text + "," + this.BoxDepreciacion.Text + "," + this.BoxValorNeto.Text + ",'" + this.BoxFechaCompra.Text + "'," + this.BoxDepreciacionMensual.Text + "," + this.BoxTVida.Text + ");insert into Bienes values ('" + this.BoxCodigo.Text + "','1','" + this.BoxCodigoAmbiente.Text + "')");
                this.con.ActualizarGrid(this.Grid1, "select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Muebles union select Codigo,Descripcion,Estado,Observacion,Fecha_Compra,Valor_Historico,Valor_Neto,Depreciacion,Tiempo_Vida from Computo");
                this.con.Desconectar();
            }
        }
    }
}
