using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Servicio
{
    public class Servicio : ICRUD<gapharma_models.SERVICIO>
    {
        public void delete(SERVICIO obj)
        {
            throw new NotImplementedException();
        }

        public List<SERVICIO> getAll()
        {
            using (gapharmaEntities1 db = new gapharmaEntities1()) {
                return db.SERVICIO.ToList<SERVICIO>();
            }
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
