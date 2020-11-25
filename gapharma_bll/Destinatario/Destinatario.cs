using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Destinatario
{
    public class Destinatario : ICRUD<gapharma_models.DESTINATARIO>
    {

        gapharma_dal.Destinatario.Destinatario sDestinatario = new gapharma_dal.Destinatario.Destinatario();
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
            return null;
        }

        public List<DESTINATARIO> getByIdAll(long id)
        {
            List<gapharma_models.DESTINATARIO> sList;
            try
            {
                sList = sDestinatario.getByIdAll(id);
            }
            catch (Exception)
            {

                throw;
            }

            return sList;
        }

        public void save(List<DESTINATARIO> list)
        {
            throw new NotImplementedException();
        }

        public void save(DESTINATARIO obj)
        {
            sDestinatario.save(obj);
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
