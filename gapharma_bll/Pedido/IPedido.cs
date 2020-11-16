using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Pedido
{
    interface IPedido
    {
        List<gapharma_models.ViewModels.PedidoW> get();
        List<gapharma_models.ViewModels.PedidoW> get(long id);
    }
}
