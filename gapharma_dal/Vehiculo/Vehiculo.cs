using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Vehiculo
{
    public class Vehiculo : ICRUD<gapharma_models.VEHICULO>
    {
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
            using (gapharmaEntities1 db = new gapharmaEntities1()) {
                return (from d in db.VEHICULO
                        where d.ZONAS_ID == id
                        select d).ToList<gapharma_models.VEHICULO>();
            }
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
