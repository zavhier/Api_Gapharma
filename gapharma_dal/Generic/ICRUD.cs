using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Generic
{
 
    public interface ICRUD<T>
    {
        List<T> getAll();
        T getByid(long id);

        List<T> getByIdAll(long id);
        void save(List<T> list);
        void save(T obj);
        void delete(T obj);
        void update(T obj);
        void update(List<T> lis);

    }
}
