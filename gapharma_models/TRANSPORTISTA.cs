//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gapharma_models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRANSPORTISTA
    {
        public int TRANSPORTISTA_ID { get; set; }
        public Nullable<int> EMPLEADO_ID { get; set; }
        public int NUM_LIC_CONVENCIONAL { get; set; }
        public System.DateTime FECHA_VENCIMIENTO_LIC_CONVENCIONAL { get; set; }
        public int NUM_LIC_CAMIONEROS { get; set; }
        public System.DateTime FECHA_VENCIMIENTO_LIC_CAMIONEROS { get; set; }
        public Nullable<int> VEHICULO_ID { get; set; }
    }
}