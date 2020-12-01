using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Zonas
{
    public class Zonas : ICRUD<gapharma_models.ZONAS>
    {

        gapharma_dal.Zonas.Zonas sZonas = new gapharma_dal.Zonas.Zonas();
        public void delete(ZONAS obj)
        {
            throw new NotImplementedException();
        }

        public List<ZONAS> getAll()
        {
            throw new NotImplementedException();
        }

        public ZONAS getByid(long id)
        {
            throw new NotImplementedException();
        }

        public List<ZONAS> getByIdAll(long id)
        {
            return sZonas.getByIdAll(id);
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
