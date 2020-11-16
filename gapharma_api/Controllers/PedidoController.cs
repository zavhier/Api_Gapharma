using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gapharma_api.Controllers
{
    public class PedidoController : ApiController
    {

        gapharma_bll.Pedido.Pedido sPedido = new gapharma_bll.Pedido.Pedido();


        // GET api/<controller>
        public List<gapharma_models.ViewModels.PedidoW> Get()
        {
            return sPedido.get() ;
        
        }

        // GET api/<controller>/5
        public  List<gapharma_models.ViewModels.PedidoW>  Get(int id)
        {
            return sPedido.get(id);
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