﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gapharma_dal.Cliente
{
    interface ICliente<T>
    {
        List<T> get();
    }
}
