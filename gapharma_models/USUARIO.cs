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
    
    public partial class USUARIO
    {
        public int USUARIO_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> HABILITADO { get; set; }
        public Nullable<int> USUARIO_ROL_ID { get; set; }
        public Nullable<System.DateTime> FECHA_ALTA { get; set; }
        public Nullable<int> ERROR_CONTRASEÑA { get; set; }
        public Nullable<int> EMPRESA_ID { get; set; }
    }
}