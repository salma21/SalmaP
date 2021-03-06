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
    
    public partial class Achat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Achat()
        {
            this.Bien = new HashSet<Bien>();
            this.Vehicule = new HashSet<Vehicule>();
        }
    
        public int Id_achat { get; set; }
        public int idDelegation { get; set; }
        public int Id_fournisseur { get; set; }
        public Nullable<System.DateTime> Date_livraison { get; set; }
        public Nullable<int> Num_facture { get; set; }
        public Nullable<int> Num_commande { get; set; }
        public Nullable<System.DateTime> Date_d_achat { get; set; }
        public Nullable<decimal> Prix_d_achat { get; set; }
        public Nullable<int> Num_livraison { get; set; }
    
        public virtual Fournisseur Fournisseur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bien> Bien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicule> Vehicule { get; set; }
    }
}
