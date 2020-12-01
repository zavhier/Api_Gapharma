using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gapharma_api.Controllers
{


    public class TransportistaController : ApiController
    {
    
        gapharma_bll.Transportista.Transportista sTransportista = new gapharma_bll.Transportista.Transportista(); 

        List<gapharma_models.TRANSPORTISTA> Get(long value) {
            
            return sTransportista.getByIdAll(value);
        }

    
    }
}
