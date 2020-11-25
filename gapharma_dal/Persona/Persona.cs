using gapharma_dal.Generic;
using gapharma_models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Persona
{
    public class Persona : ICRUD<gapharma_models.PERSONA>
    {
        public void delete(PERSONA obj)
        {
            throw new NotImplementedException();
        }

        public List<PERSONA> getAll()
        {
            using (gapharmaEntities1 db = new gapharmaEntities1()) {
               return  db.PERSONA.ToList();
                
            }
        }

        public PERSONA getByid(long id)
        {
            using (gapharmaEntities1 db = new gapharmaEntities1()) {

                return db.PERSONA.Find(id);
            }
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
            using (gapharmaEntities1 db = new gapharmaEntities1())
            {
                try
                {
                    db.PERSONA.Add(obj);
                    db.SaveChanges();

                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
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
