//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntidadesNegocio
{
    using System;
    using System.Collections.Generic;
    
    public partial class armaExplosiva
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public armaExplosiva()
        {
            this.paisArmaExplosiva = new HashSet<paisArmaExplosiva>();
        }
    
        public long id_armaExplosiva { get; set; }
        public string nombre { get; set; }
        public Nullable<int> peso { get; set; }
        public Nullable<int> alcance { get; set; }
        public Nullable<int> poderDestruccion { get; set; }
        public Nullable<long> idMarca_Fk { get; set; }
    
        public virtual marca marca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<paisArmaExplosiva> paisArmaExplosiva { get; set; }
    }
}