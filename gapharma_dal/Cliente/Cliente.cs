using gapharma_dal.Generic;
using gapharma_models;
using gapharma_models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Cliente
{
    public class Cliente : ICRUD<gapharma_models.CLIENTE> , ICliente<gapharma_models.ViewModels.ClienteW>
    {
        public void delete(CLIENTE obj)
        {
            throw new NotImplementedException();
        }

        public List<ClienteW> get()
        {
            using (gapharmaEntities1 db = new gapharmaEntities1()) {

                var list = (from c in db.CLIENTE
                            join e in db.ESTADO
                            on c.ESTADO_ID equals e.ESTADO_ID
                            join p in db.PERSONA
                            on c.PERSONA_ID equals p.PERSONA_ID
                            select new gapharma_models.ViewModels.ClienteW
                            {
                                Cliente_id = c.CLIENTE_ID,
                                Razon_social = c.RAZONSOCIAL,
                                Tipo_estado = e.TIPO_ESTADO,
                                Nombre  = p.NOMBRE,
                                Apellido   =  p.APELLIDO,
                                Email  = p.EMAIL,
                                Telefono_1 = p.TELEFONO_1
                             }

                            ).AsQueryable();

                return list.ToList<gapharma_models.ViewModels.ClienteW>();
            }
        }

        public List<CLIENTE> getAll()
        {
            throw new NotImplementedException();
        }

        public CLIENTE getByid(long id)
        {
            throw new NotImplementedException();
        }

        public List<CLIENTE> getByIdAll(long id)
        {
            throw new NotImplementedException();
        }

        public void save(List<CLIENTE> list)
        {
            throw new NotImplementedException();
        }

        public void save(CLIENTE obj)
        {
            throw new NotImplementedException();
        }

        public void update(CLIENTE obj)
        {
            throw new NotImplementedException();
        }

        public void update(List<CLIENTE> lis)
        {
            throw new NotImplementedException();
        }
    }
}
