//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nomina2019.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPeriodosPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPeriodosPago()
        {
            this.tblEmpleados = new HashSet<tblEmpleados>();
        }
    
        public int iIdPeriodoPago { get; set; }
        public string cNombrePeriodo { get; set; }
        public Nullable<int> iDiasxPeriodo { get; set; }
        public Nullable<System.DateTime> dtCreacion { get; set; }
        public Nullable<System.DateTime> dtModificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmpleados> tblEmpleados { get; set; }
    }
}
