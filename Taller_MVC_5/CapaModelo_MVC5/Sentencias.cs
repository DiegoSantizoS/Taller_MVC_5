using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC5
{
    public class Sentencias
    {
        Conexion conn = new Conexion();
        public OdbcDataAdapter llenarTbl(string nombreTabla)
        {
            string sSQl = "SELECT * FROM " + nombreTabla + " ;";
            OdbcDataAdapter daSentencias = new OdbcDataAdapter(sSQl, conn.conexion());
            return daSentencias;
        }
    }
}
