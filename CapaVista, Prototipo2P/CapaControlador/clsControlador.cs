using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;

namespace CapaControlador
{
    public class clsControlador
    {
        clsSentencias sn = new clsSentencias();

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void guardarmaestro(string codigo, string nombre, string direccion, string telefono, string correo, string estado)
        {            
            string cadena = "insert into maestros values ('"+ codigo + "','"+ nombre + "','" + direccion + "','" + telefono + "','" + correo + "','" + estado + "');";
            sn.conex(cadena);
            MessageBox.Show("Registro del maestro guardado");
        }

        public void modificarmaestro(string codigo, string nombre, string direccion, string telefono, string correo, string estado)
        {
            string cadena2 = "update maestros set nombre_maestro = '" + nombre + "',direccion_maestro = '" + direccion + "',telefono_maetro = '" + telefono + "',email_maestro = '" + correo + "',estatus_maestro = '" + estado + "' where codigo_maestro = '" + codigo + "';";
            sn.conex(cadena2);
            MessageBox.Show("Registro del maestro modificado");
        }

        public void eliminarmaestro(string codigo)
        {
            string cadena3 = "delete from maestros where codigo_maestro = '" + codigo + "';";
            sn.conex(cadena3);
            MessageBox.Show("Registro del maestro eliminado");
        }

        public void guardaralumno(string codigo, string nombre, string direccion, string telefono, string correo, string estado)
        {
            string cadena = "insert into alumnos values('" + codigo + "','" + nombre + "','" + direccion + "','" + telefono + "','" + correo + "','" + estado + "');";
            sn.conex(cadena);
            MessageBox.Show("Registro del alumno guardado");
        }

        public void modificaralumno(string codigo, string nombre, string direccion, string telefono, string correo, string estado)
        {
            string cadena2 = "update alumnos set nombre_alumno = '" + nombre + "',direccion_alumno = '" + direccion + "',telefono_alumno = '" + telefono + "',email_alumno = '" + correo + "',estatus_alumno = '" + estado + "' where carnet_alumno = '" + codigo + "';";
            sn.conex(cadena2);
            MessageBox.Show("Registro del alumno modificado");            
        }

        public void eliminaralumno(string codigo)
        {
            string cadena3 = "delete from alumnos where carnet_alumno = '" + codigo + "';";
            sn.conex(cadena3);
            MessageBox.Show("Registro del alumno eliminado");
        }

    }
}
