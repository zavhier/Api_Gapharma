using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gapharma_api.Controllers
{
    public class PersonaController : ApiController
    {

        gapharma_bll.Persona.Persona sPersona = new gapharma_bll.Persona.Persona();

        public gapharma_models.PERSONA Get(long id) {
            return sPersona.getByid(id);
        }
        public List<gapharma_models.PERSONA> Get() {

            return sPersona.getAll();
                
         
        }
        public void Post(gapharma_models.PERSONA value) {

            sPersona.save(value); 
        }
    
    }
}
