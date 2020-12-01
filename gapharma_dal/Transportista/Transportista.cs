using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Transportista
{
    public class Transportista : ICRUD<gapharma_models.TRANSPORTISTA>
    {
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
            using (gapharmaEntities1 db = new gapharmaEntities1()) {
                return (List<gapharma_models.TRANSPORTISTA>)db.TRANSPORTISTA.ToList<gapharma_models.TRANSPORTISTA>().Where(p => p.VEHICULO_ID == id);
            }
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
