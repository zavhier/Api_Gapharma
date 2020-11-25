using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gapharma_api.Controllers
{
    public class DestinatarioController : ApiController
    {
        // GET api/<controller>

        gapharma_bll.Destinatario.Destinatario sDestinatario = new gapharma_bll.Destinatario.Destinatario();

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public List<gapharma_models.DESTINATARIO> Get(int id)
        {
            return sDestinatario.getByIdAll(id);
        }

        // POST api/<controller>
        public void Post(gapharma_models.DESTINATARIO value)
        {
            sDestinatario.save(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}