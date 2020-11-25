using gapharma_dal.Generic;
using gapharma_models;
using gapharma_models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Pedido
{
    public class Pedido : ICRUD<gapharma_models.CABECERA_DOCUMENTO>, IPedido
    {

        gapharma_dal.Pedido.Pedido sPedido = new gapharma_dal.Pedido.Pedido();

        public void delete(CABECERA_DOCUMENTO obj)
        {
            throw new NotImplementedException();
        }

        public List<PedidoW> get()
        {
            List<PedidoW> sList;

            try
            {
                sList = sPedido.get();
            }
            catch (Exception)
            {

                throw;
            }
            return sList;
        }

        public List<PedidoW> get(long id)
        {
            List<PedidoW> sList;
            try
            {
                sList = sPedido.get().FindAll(p=> p.Cliente_id == id).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return sList;

        }

        public List<CABECERA_DOCUMENTO> getAll()
        {
            throw new NotImplementedException();
        }

        public CABECERA_DOCUMENTO getByid(long id)
        {
            throw new NotImplementedException();
        }

        public List<CABECERA_DOCUMENTO> getByIdAll(long id)
        {
            throw new NotImplementedException();
        }

        public void save(List<CABECERA_DOCUMENTO> list)
        {
            throw new NotImplementedException();
        }

        public void save(CABECERA_DOCUMENTO obj)
        {
            obj.FECHA_EMISION = DateTime.Now;
            sPedido.save(obj);

        }

        public void update(CABECERA_DOCUMENTO obj)
        {
            throw new NotImplementedException();
        }

        public void update(List<CABECERA_DOCUMENTO> lis)
        {
            throw new NotImplementedException();
        }

    }
   
}
