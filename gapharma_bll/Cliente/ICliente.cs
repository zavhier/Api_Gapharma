using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_bll.Cliente
{
    interface ICliente
    {
       List<gapharma_models.ViewModels.ClienteW> get();
          
    }
}
