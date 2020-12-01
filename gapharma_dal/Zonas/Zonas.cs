using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Zonas
{
    public class Zonas : ICRUD<gapharma_models.ZONAS>
    {
        public void delete(ZONAS obj)
        {
            throw new NotImplementedException();
        }

        public List<ZONAS> getAll()
        {
            return null;
        }

        public ZONAS getByid(long id)
        {
            return null; 
        }

        public List<ZONAS> getByIdAll(long id)
        {
            using (gapharmaEntities1 db = new gapharmaEntities1()) {
               return (from d in db.ZONAS
                        where d.CODIGO_POSTAL == id
                        select d).ToList<gapharma_models.ZONAS>();
            }
        }

        public void save(List<ZONAS> list)
        {
            throw new NotImplementedException();
        }

        public void save(ZONAS obj)
        {
            throw new NotImplementedException();
        }

        public void update(ZONAS obj)
        {
            throw new NotImplementedException();
        }

        public void update(List<ZONAS> lis)
        {
            throw new NotImplementedException();
        }
    }
}
