//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Net_2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENTAS_VHS
    {
        public int id_mov { get; set; }
        public int rut_usr { get; set; }
        public string nombre_usr { get; set; }
        public int Ident_Marca { get; set; }
        public string Nombre_Marca { get; set; }
        public Nullable<int> VHS { get; set; }
        public Nullable<int> forma_pag { get; set; }
    
        public virtual STOCK STOCK { get; set; }
        public virtual TIP_PAG TIP_PAG { get; set; }
    }
}
