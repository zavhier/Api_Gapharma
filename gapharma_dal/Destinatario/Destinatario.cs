using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Destinatario
{
    public class Destinatario : ICRUD<gapharma_models.DESTINATARIO>
    {
        public void delete(DESTINATARIO obj)
        {
            throw new NotImplementedException();
        }

        public List<DESTINATARIO> getAll()
        {
            throw new NotImplementedException();
        }

        public DESTINATARIO getByid(long id)
        {
            throw new NotImplementedException();
        }

        public List<DESTINATARIO> getByIdAll(long id)
        {
            using (gapharmaEntities1 bd = new gapharmaEntities1()) {

                return (from d in bd.DESTINATARIO
                               where d.CLIENTE_ID == id
                               select d).ToList<gapharma_models.DESTINATARIO>();

            }
        }

        public void save(List<DESTINATARIO> list)
        {
            throw new NotImplementedException();
        }

        public void save(DESTINATARIO obj)
        {
            using (gapharmaEntities1 db = new gapharmaEntities1()) {

                db.DESTINATARIO.Add(obj);
                db.SaveChanges();
            }
        }

        public void update(DESTINATARIO obj)
        {
            throw new NotImplementedException();
        }

        public void update(List<DESTINATARIO> lis)
        {
            throw new NotImplementedException();
        }
    }
}
