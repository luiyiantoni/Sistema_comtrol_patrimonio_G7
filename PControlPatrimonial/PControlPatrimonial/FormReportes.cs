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
    public partial class FormReportes : Form
    {
        Conexion con = new Conexion();
        int id;
        bool editar=false;

        public FormReportes()
        {
            InitializeComponent();
            //Grid1.DataSource = usr.MostrarUsuarios();
            con.ActualizarGrid(this.Grid1, "exec reportes");
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
    }
}
