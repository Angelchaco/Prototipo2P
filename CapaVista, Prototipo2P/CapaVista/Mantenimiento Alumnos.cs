using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Mantenimiento_Alumnos : Form
    {
        public Mantenimiento_Alumnos()
        {
            InitializeComponent();
            actualizardatagriew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            con.guardaralumno(txtCodigo.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtEstado.Text);
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        clsControlador con = new clsControlador();

        string tabla = "Alumnos";
        public void actualizardatagriew()
        {
            DataTable dt = con.llenarTbl(tabla);
            dataGridView1.DataSource = dt;

        }        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.modificaralumno(txtCodigo.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtEstado.Text);
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminaralumno(txtCodigo.Text);
            limpiar();
        }

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtEstado.Text = "";
        }
    }
}
