using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Transportista
{
    public class Transportista : ICRUD<gapharma_models.TRANSPORTISTA>
    {
        gapharma_dal.Transportista.Transportista transportista = new gapharma_dal.Transportista.Transportista();
        public void delete(TRANSPORTISTA obj)
        {
            throw new NotImplementedException();
        }

        public List<TRANSPORTISTA> getAll()
        {
            throw new NotImplementedException();
        }

        public TRANSPORTISTA getByid(long id)
        {
            throw new NotImplementedException();
        }

        public List<TRANSPORTISTA> getByIdAll(long id)
        {
            return transportista.getByIdAll(id);
        }

        public void save(List<TRANSPORTISTA> list)
        {
            throw new NotImplementedException();
        }

        public void save(TRANSPORTISTA obj)
        {
            throw new NotImplementedException();
        }

        public void update(TRANSPORTISTA obj)
        {
            throw new NotImplementedException();
        }

        public void update(List<TRANSPORTISTA> lis)
        {
            throw new NotImplementedException();
        }
    }
}
