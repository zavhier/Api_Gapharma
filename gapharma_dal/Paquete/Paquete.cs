using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Paquete
{
    public class Paquete : ICRUD<gapharma_models.PAQUETE>
    {
        public void delete(PAQUETE obj)
        {
            throw new NotImplementedException();
        }

        public List<PAQUETE> getAll()
        {
            using (gapharmaEntities1 db = new gapharmaEntities1()) {

                return db.PAQUETE.ToList();
            }
        }

        public PAQUETE getByid(long id)
        {
            throw new NotImplementedException();
        }

        public List<PAQUETE> getByIdAll(long id)
        {
            throw new NotImplementedException();
        }

        public void save(List<PAQUETE> list)
        {
            throw new NotImplementedException();
        }

        public void save(PAQUETE obj)
        {
            throw new NotImplementedException();
        }

        public void update(PAQUETE obj)
        {
            throw new NotImplementedException();
        }

        public void update(List<PAQUETE> lis)
        {
            throw new NotImplementedException();
        }
    }
}
