using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_models.ViewModels
{
    public class PedidoW
    {

        public int Cabecera_id { get; set; }
        public DateTime Fecha_emision { get; set; }
        public DateTime Fecha_envio { get; set; }
        public DateTime Fecha_retiro { get; set; }
        public String  Cliente { get; set; }
        public String Destinatario { get; set; }
        public String  Estado { get; set; }
        public String Servicio { get; set; }
        public   String  Empresa { get; set; }
        public int  Cliente_id { get; set; }

    }
}
