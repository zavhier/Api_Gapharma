using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gapharma_api.Controllers
{
    public class ClienteController : ApiController
    {

        gapharma_bll.Cliente.Cliente sCliente = new gapharma_bll.Cliente.Cliente();
        // GET api/<controller>
        public List<gapharma_models.ViewModels.ClienteW> Get()
        {

            return sCliente.get();
          
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
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