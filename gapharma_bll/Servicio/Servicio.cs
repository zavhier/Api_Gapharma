using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Servicio
{
    public class Servicio : ICRUD<gapharma_models.SERVICIO>
    {
        gapharma_dal.Servicio.Servicio sServicio = new gapharma_dal.Servicio.Servicio();
        public void delete(SERVICIO obj)
        {
            throw new NotImplementedException();
        }

        public List<SERVICIO> getAll()
        {
            return sServicio.getAll();
        }

        public SERVICIO getByid(long id)
        {
            throw new NotImplementedException();
        }

        public List<SERVICIO> getByIdAll(long id)
        {
            throw new NotImplementedException();
        }

        public void save(List<SERVICIO> list)
        {
            throw new NotImplementedException();
        }

        public void save(SERVICIO obj)
        {
            throw new NotImplementedException();
        }

        public void update(SERVICIO obj)
        {
            throw new NotImplementedException();
        }

        public void update(List<SERVICIO> lis)
        {
            throw new NotImplementedException();
        }
    }
}
