using gapharma_dal.Generic;
using gapharma_models;
using gapharma_models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Cliente
{
    public class Cliente : ICRUD<gapharma_models.CLIENTE>  , ICliente
    {

         gapharma_dal.Cliente.Cliente   sCliente = new gapharma_dal.Cliente.Cliente();

        public void delete(CLIENTE obj)
        {
            throw new NotImplementedException();
        }

        public List<ClienteW> get()
        {
            List<ClienteW> sList;
            try
            {
                sList = sCliente.get();
            }
            catch (Exception ex)
            {

                throw;
            }

            return sList;
        }

        public List<CLIENTE> getAll()
        {
            throw new NotImplementedException();
        }

        public CLIENTE getByid(long id)
        {
            throw new NotImplementedException();
        }

        public List<CLIENTE> getByIdAll(long id)
        {
            throw new NotImplementedException();
        }

        public void save(List<CLIENTE> list)
        {
            throw new NotImplementedException();
        }

        public void save(CLIENTE obj)
        {
            throw new NotImplementedException();
        }

        public void update(CLIENTE obj)
        {
            throw new NotImplementedException();
        }

        public void update(List<CLIENTE> lis)
        {
            throw new NotImplementedException();
        }
    }
}
