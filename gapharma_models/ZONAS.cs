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
    
    public partial class ZONAS
    {
        public int ZONAS_ID { get; set; }
        public  int CODIGO_POSTAL { get; set; }
        public string LOCALIDAD { get; set; }
        public int DISTRITO_ID { get; set; }
        public int PARTIDO_ID { get; set; }
        public string DESCRIPCION_PARTIDO { get; set; }
        public  bool HABILITADO { get; set; }
        public int ZONA_UNIFICADA { get; set; }
    }
}
