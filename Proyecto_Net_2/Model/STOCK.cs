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
    
    public partial class STOCK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STOCK()
        {
            this.VENTAS_VHS = new HashSet<VENTAS_VHS>();
        }
    
        public int id_modelo { get; set; }
        public Nullable<int> id_marca { get; set; }
        public string modelo_vhs { get; set; }
        public decimal Valor_vhs { get; set; }
        public Nullable<int> tipo_vhs { get; set; }
        public int Cant_stok { get; set; }
    
        public virtual MARCAS_vhs MARCAS_vhs { get; set; }
        public virtual tip_vhs tip_vhs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTAS_VHS> VENTAS_VHS { get; set; }
    }
}