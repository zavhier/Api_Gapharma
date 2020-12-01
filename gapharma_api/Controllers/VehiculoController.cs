using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gapharma_api.Controllers
{
    public class VehiculoController : ApiController
    {
        gapharma_bll.Vehiculo.Vehiculo sVehiculo = new gapharma_bll.Vehiculo.Vehiculo();
      
        // GET api/<controller>/5
       public List<gapharma_models.VEHICULO> Get(int id) {
                      
            return sVehiculo.getByIdAll(id);
        }
    
    }
}
