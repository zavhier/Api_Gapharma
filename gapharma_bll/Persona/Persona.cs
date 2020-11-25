using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Persona
{
    public class Persona : ICRUD<gapharma_models.PERSONA>
    {

        gapharma_dal.Persona.Persona sPersona = new gapharma_dal.Persona.Persona();
        public void delete(PERSONA obj)
        {
            throw new NotImplementedException();
        }

        public List<PERSONA> getAll()
        {
           return   sPersona.getAll();
        }

        public PERSONA getByid(long id)
        {
            return sPersona.getByid(id);
        }

        public List<PERSONA> getByIdAll(long id)
        {
            throw new NotImplementedException();
        }

        public void save(List<PERSONA> list)
        {
            throw new NotImplementedException();
        }

        public void save(PERSONA obj)
        {
            sPersona.save(obj);

        }

        public void update(PERSONA obj)
        {
            throw new NotImplementedException();
        }

        public void update(List<PERSONA> lis)
        {
            throw new NotImplementedException();
        }
    }
}
