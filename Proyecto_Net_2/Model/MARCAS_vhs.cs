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
    
    public partial class MARCAS_vhs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MARCAS_vhs()
        {
            this.CNC = new HashSet<CNC>();
            this.STOCK = new HashSet<STOCK>();
        }
    
        public int id_MARCA { get; set; }
        public string Nombre_MARCA { get; set; }
        public int RUT_MARCA { get; set; }
        public int Dv_marca { get; set; }
        public int comuna { get; set; }
        public int region { get; set; }
        public string direccion { get; set; }
        public string tip_Vhs_Cam { get; set; }
        public string tip_Vhs_SUV { get; set; }
        public string tip_Vhs_Furg { get; set; }
        public string tip_Vhs_Camioneta { get; set; }
        public string tip_Vhs_Sed { get; set; }
        public string Est_VHS_Nuevo { get; set; }
        public string Est_VHS_Sem_Nue { get; set; }
        public string Est_VHS_Usado { get; set; }
        public string Tip_Comb_Gas { get; set; }
        public string Tip_Comb_Dies { get; set; }
        public string Tip_Comb_Hibri { get; set; }
        public string Tip_Comb_Elec { get; set; }
        public string Tip_Comb_Hidro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNC> CNC { get; set; }
        public virtual Comunas Comunas { get; set; }
        public virtual region region1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCK> STOCK { get; set; }
    }
}
