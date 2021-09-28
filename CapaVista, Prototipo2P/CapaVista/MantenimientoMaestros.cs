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
    public partial class MantenimientoMaestros : Form
    {
        public MantenimientoMaestros()
        {
            InitializeComponent();
            actualizardatagriew();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        clsControlador con = new clsControlador();

        string tabla = "maestros";
        public void actualizardatagriew()
        {
            DataTable dt = con.llenarTbl(tabla);
            dataGridView1.DataSource = dt;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            con.guardarmaestro(txtCodigo.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtEstado.Text);
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.modificarmaestro(txtCodigo.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtEstado.Text);
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarmaestro(txtCodigo.Text);
            limpiar();
        }

        public void limpiar(){
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtEstado.Text = "";
        }
    }
}
