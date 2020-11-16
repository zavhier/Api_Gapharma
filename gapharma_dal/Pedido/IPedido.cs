using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Pedido
{
    interface IPedido <T>
    {
        List<T> get();
    
    }
}
