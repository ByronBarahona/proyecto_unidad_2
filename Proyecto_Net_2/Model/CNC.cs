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
    
    public partial class CNC
    {
        public string Nom_CNC { get; set; }
        public string Apell_CNC { get; set; }
        public int ident_CNC { get; set; }
        public int dvf_CNC { get; set; }
        public string direccion_CNC { get; set; }
        public int region { get; set; }
        public int comuna { get; set; }
        public int rut_marca { get; set; }
    
        public virtual Comunas Comunas { get; set; }
        public virtual region region1 { get; set; }
        public virtual MARCAS_vhs MARCAS_vhs { get; set; }
    }
}