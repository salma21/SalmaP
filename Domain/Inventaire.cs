//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventaire()
        {
            this.Association_30 = new HashSet<Association_30>();
            this.Association_31 = new HashSet<Association_31>();
        }
    
        public int Id_inventaire { get; set; }
        public string Nom_ { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Association_30> Association_30 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Association_31> Association_31 { get; set; }
    }
}
