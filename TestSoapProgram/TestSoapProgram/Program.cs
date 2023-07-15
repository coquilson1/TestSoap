using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSoapProgram.DataAccess.Access;
using TestSoapProgram.DataAccess.Models;
using TestSoapProgram.ServiceReferenceTest;

namespace TestSoapProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int registros = 0;
            DARequest objDARequest = new DARequest();
            List<Request> listRequest = new List<Request>();
            TestSoapProgram.ServiceReferenceTest.ZECP_WS_MARCA_VISUAL_ASISTClient _objZECP_WS_MARCA_VISUAL_ASISTClient = new ZECP_WS_MARCA_VISUAL_ASISTClient();
           
            ZwsMarcaVisualAsist objZwsMarcaVisualAsist = new ZwsMarcaVisualAsist(); 
            ZesMarcaVisual[] listZesMarcaVisual;
            ZwsMarcaVisualAsistResponse objZwsMarcaVisualAsistResponse = new ZwsMarcaVisualAsistResponse();

            Console.Write("Registros: ");
            registros = Convert.ToInt32(Console.ReadLine());
            listRequest = objDARequest.ListarRequest(registros);
            listZesMarcaVisual = new ZesMarcaVisual[listRequest.Count()];
            
            for (int i=0; i<listRequest.Count(); i++) {
                
                ZesMarcaVisual objZesMarcaVisual = new ZesMarcaVisual();

                objZesMarcaVisual.CodigoTrab = listRequest[i].vchCodigoPersona;
                objZesMarcaVisual.Dni = listRequest[i].vchNumDocumento;
                objZesMarcaVisual.Fecha = listRequest[i].Fecha;
                objZesMarcaVisual.HoraIni = listRequest[i].Hora;

                listZesMarcaVisual[i] = objZesMarcaVisual;

            }

            objZwsMarcaVisualAsist.ItMarca = listZesMarcaVisual;
            
            objZwsMarcaVisualAsistResponse = _objZECP_WS_MARCA_VISUAL_ASISTClient.ZwsMarcaVisualAsist(objZwsMarcaVisualAsist);


            Console.Write("La cantidad de registros es: " + Convert.ToString(listZesMarcaVisual.Count()));
            Console.ReadLine();
        
        }
    }
}
