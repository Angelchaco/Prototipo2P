using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class clsSentencias
    {
        clsConexion cn = new clsConexion();

        public OdbcDataAdapter llenarTbl(string tabla)//obtinene el contenio de una tabla
        {
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void conex(string cadena)
        {
            try
            {                
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Capa Modelo --> sentencias: guardar" + e);
            }
        }
        
    }
}
