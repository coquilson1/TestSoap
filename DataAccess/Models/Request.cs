using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Request
    {
        public string vchCodigoPersona { get; set; }
        public string vchNumDocumento { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
    }
}
