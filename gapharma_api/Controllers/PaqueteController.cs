using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gapharma_api.Controllers
{
    public class PaqueteController : ApiController
    {

        gapharma_bll.Paquete.Paquete sPaquete = new gapharma_bll.Paquete.Paquete();

       public List<gapharma_models.PAQUETE> Get() {
            return sPaquete.getAll();

        }

    }
}
