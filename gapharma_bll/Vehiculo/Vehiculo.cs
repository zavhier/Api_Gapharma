using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Vehiculo
{
    public class Vehiculo : ICRUD<gapharma_models.VEHICULO>
    {
        gapharma_dal.Vehiculo.Vehiculo sVe = new gapharma_dal.Vehiculo.Vehiculo();
        
        public void delete(VEHICULO obj)
        {
            throw new NotImplementedException();
        }

        public List<VEHICULO> getAll()
        {
            throw new NotImplementedException();
        }

        public VEHICULO getByid(long id)
        {
            throw new NotImplementedException();
        }

        public List<VEHICULO> getByIdAll(long id)
        {
            return sVe.getByIdAll(id);
        }

        public void save(List<VEHICULO> list)
        {
            throw new NotImplementedException();
        }

        public void save(VEHICULO obj)
        {
            throw new NotImplementedException();
        }

        public void update(VEHICULO obj)
        {
            throw new NotImplementedException();
        }

        public void update(List<VEHICULO> lis)
        {
            throw new NotImplementedException();
        }
    }
}
