using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            TestSoapProgram.ServiceReferenceTest.ZECP_WS_MARCA_VISUAL_ASISTClient _objZECP_WS_MARCA_VISUAL_ASISTClient = new ZECP_WS_MARCA_VISUAL_ASISTClient("Marcaciones");
           
            ZwsMarcaVisualAsist objZwsMarcaVisualAsist = new ZwsMarcaVisualAsist(); 
            ZesMarcaVisual[] listZesMarcaVisual;
            ZesResultado[] listZesMarcaResultado = new ZesResultado[0];
            ZwsMarcaVisualAsistResponse objZwsMarcaVisualAsistResponse = new ZwsMarcaVisualAsistResponse();
            ZwsMarcaVisualAsistResponse1 objZwsMarcaVisualAsistResponse1 = new ZwsMarcaVisualAsistResponse1();
            ZwsMarcaVisualAsistRequest objZwsMarcaVisualAsistRequest;

            Console.Write("Registros: ");
            registros = Convert.ToInt32(Console.ReadLine());
            listRequest = objDARequest.ListarRequest(registros);
            listZesMarcaVisual = new ZesMarcaVisual[listRequest.Count()];
            
            for (int i=0; i<listRequest.Count(); i++) {
                
                ZesMarcaVisual objZesMarcaVisual = new ZesMarcaVisual();

                objZesMarcaVisual.CodigoTrab = listRequest[i].vchCodigoPersona;
                objZesMarcaVisual.Dni = listRequest[i].vchNumDocumento;
                objZesMarcaVisual.Fecha = listRequest[i].Fecha;
                //objZesMarcaVisual.Evento = "";
                objZesMarcaVisual.HoraIni = listRequest[i].Hora;
                //objZesMarcaVisual.HoraFin = "";
                //objZesMarcaVisual.Entrada = "";
                //objZesMarcaVisual.SalidaRef = "";
                //objZesMarcaVisual.EntradaRef = "";
                //objZesMarcaVisual.Salida = "";
                //objZesMarcaVisual.MarcaAdc01 = "";
                //objZesMarcaVisual.MarcaAdc02 = "";
                //objZesMarcaVisual.Asistencia = "";
                //objZesMarcaVisual.Jornada = "";
                //objZesMarcaVisual.Refrigerio = "";
                //objZesMarcaVisual.Atraso = "";
                //objZesMarcaVisual.SalidaTem = "";
                //objZesMarcaVisual.Ausencia = "";
                //objZesMarcaVisual.HorasAdic = "";
                //objZesMarcaVisual.Horas25 = "";
                //objZesMarcaVisual.Horas35 = "";
                //objZesMarcaVisual.Horas100 = "";
                //objZesMarcaVisual.HorasTot = "";
                //objZesMarcaVisual.HorasNoc = "";
                //objZesMarcaVisual.Justificacion = "";
                //objZesMarcaVisual.InicioJust = "";
                //objZesMarcaVisual.FinJust = "";
                //objZesMarcaVisual.TotalHrsJust = "";

                listZesMarcaVisual[i] = objZesMarcaVisual;

            }

            objZwsMarcaVisualAsist.ItMarca = listZesMarcaVisual;
            objZwsMarcaVisualAsist.ItResul = listZesMarcaResultado;
            objZwsMarcaVisualAsistRequest = new ZwsMarcaVisualAsistRequest(objZwsMarcaVisualAsist);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            _objZECP_WS_MARCA_VISUAL_ASISTClient.ClientCredentials.UserName.UserName = "DSN_INTER01";
            _objZECP_WS_MARCA_VISUAL_ASISTClient.ClientCredentials.UserName.Password = "Laredo23.*";


            objZwsMarcaVisualAsistResponse = _objZECP_WS_MARCA_VISUAL_ASISTClient.ZwsMarcaVisualAsist(objZwsMarcaVisualAsist);


            Console.Write("La cantidad de registros es: " + Convert.ToString(listZesMarcaVisual.Count()));
            Console.ReadLine();
        
        }
    }
}
