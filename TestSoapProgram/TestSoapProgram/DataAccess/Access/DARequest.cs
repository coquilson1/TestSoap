using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using TestSoapProgram.DataAccess.Models;

namespace TestSoapProgram.DataAccess.Access
{
    public class DARequest
    {
        public List<Request> ListarRequest(int p_registros) {

            List<Request> listRequest = new List<Request>();

            using (SqlConnection coon = new SqlConnection(ConfigurationManager.ConnectionStrings["conDB"].ConnectionString)) {
                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pa_JIDC_TraeMarcacionesTestLaredo";
                cmd.Parameters.Add(new SqlParameter("@p_NroMarcas", p_registros));
                cmd.Connection = coon;
                coon.Open();

                using (SqlDataReader reader = cmd.ExecuteReader()) { 
                    
                    while(reader.Read())
                    {
                        Request request = new Request();

                        request.vchCodigoPersona =  Convert.ToString(reader["vchCodigoPersona"].ToString());
                        request.vchNumDocumento = Convert.ToString(reader["vchNumDocumento"].ToString());
                        request.Fecha = Convert.ToString(reader["Fecha"].ToString());
                        request.Hora = Convert.ToString(reader["Hora"].ToString());

                        listRequest.Add(request);
                    }
                } 

            }

            return listRequest;
        }
    }
}
