using gapharma_dal.Generic;
using gapharma_models;
using gapharma_models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Pedido
{
    public class Pedido : ICRUD<gapharma_models.CABECERA_DOCUMENTO> , IPedido<gapharma_models.ViewModels.PedidoW>
    {
        public void delete(CABECERA_DOCUMENTO obj)
        {
            throw new NotImplementedException();
        }

        public List<PedidoW> get()
        {
            using (gapharmaEntities1 db = new gapharmaEntities1())
            {

                var list = (from cd in db.CABECERA_DOCUMENTO
                            join c in db.CLIENTE
                            on cd.CLIENTE_ID equals c.CLIENTE_ID
                            join d in db.DESTINATARIO
                            on cd.DESTINATARIO_ID equals d.DESTINATARIO_ID
                            join est in db.ESTADO on cd.ESTADO_ID equals est.ESTADO_ID
                            join s in db.SERVICIO on cd.SERVICIO_ID equals s.SERVICIO_ID

                            select new gapharma_models.ViewModels.PedidoW
                            {
                                Cabecera_id = cd.CABECERA_DOCUMENTO_ID,
                                Fecha_emision = cd.FECHA_EMISION,
                                Fecha_envio = cd.FECHA_RETIRO,
                                Fecha_retiro = cd.FECHA_RETIRO,
                                Cliente = c.RAZONSOCIAL,
                                Destinatario = d.RAZON_SOCIAL,
                                Estado = est.TIPO_ESTADO,
                                Servicio = s.DESCRIPCION,
                                Empresa = d.RAZON_SOCIAL,
                               Cliente_id = cd.CLIENTE_ID

                            }).AsQueryable();

                return list.ToList<PedidoW>();
            }
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
            throw new NotImplementedException();
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
