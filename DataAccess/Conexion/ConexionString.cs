using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSoapProgram;


namespace DataAccess.Conexion
{
    public class ConexionString
    {
 
        public string conexionStringText { get; set; }


        public ConexionString() {
            TestSoapProgram.ConexionStringPrincipal objConexionStringPrincipal = new TestSoapProgram.ConexionStringPrincipal();
            this.conexionStringText = objConexionStringPrincipal.cadenaConexion;
        }


    }
}
