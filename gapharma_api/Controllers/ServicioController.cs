using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gapharma_api.Controllers
{
    public class ServicioController : ApiController
    {

        gapharma_bll.Servicio.Servicio sServicio = new gapharma_bll.Servicio.Servicio();
        // GET api/<controller>
        public List<gapharma_models.SERVICIO> Get()
        {

            return sServicio.getAll();

        }


    }
}
