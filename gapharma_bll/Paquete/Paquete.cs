using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Paquete
{
    public class Paquete : ICRUD<gapharma_models.PAQUETE>
    {
        gapharma_dal.Paquete.Paquete sPaquete = new gapharma_dal.Paquete.Paquete();

        public void delete(PAQUETE obj)
        {
            throw new NotImplementedException();
        }

        public List<PAQUETE> getAll()
        {
            return sPaquete.getAll();
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
