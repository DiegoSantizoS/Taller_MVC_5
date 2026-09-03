using CapaModelo_MVC5;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_MVC5
{
    public class Controlador
    {
        Sentencias sentencia = new Sentencias();
        public DataTable llenarDgv(string nombreTabla)
        {
            OdbcDataAdapter daControlador = sentencia.llenarTbl(nombreTabla);
            
            DataTable dtControlador = new DataTable();
            daControlador.Fill(dtControlador);
            return dtControlador;
        }
    }
}
