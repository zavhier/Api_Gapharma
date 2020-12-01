using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gapharma_api.Controllers
{
    public class ZonasController : ApiController
    {

        gapharma_bll.Zonas.Zonas sZona = new gapharma_bll.Zonas.Zonas();

        // GET api/<controller>/5
        public List<gapharma_models.ZONAS> Get(int id) {

            return sZona.getByIdAll(id);
        }

     }
}
