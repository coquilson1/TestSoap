using DataAccess.Conexion;
using DataAccess.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DARequest
    {
        private ConexionString objConexionString = new ConexionString();

        public List<Request> listRequest(int p_registros) {
            using (SqlConnection coon = new SqlConnection(objConexionString.conexionStringText))

            return null;
        } 

    }
}
