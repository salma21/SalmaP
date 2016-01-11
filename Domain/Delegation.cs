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
    
    public partial class Delegation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delegation()
        {
            this.Batiment = new HashSet<Batiment>();
            this.Fournisseur = new HashSet<Fournisseur>();
            this.Societe_assurance = new HashSet<Societe_assurance>();
            this.Societe_maintenance = new HashSet<Societe_maintenance>();
        }
    
        public int idPays { get; set; }
        public int idRegion { get; set; }
        public int idGouvernorat { get; set; }
        public int idDelegation { get; set; }
        public string libelle { get; set; }
        public Nullable<int> Code_postal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Batiment> Batiment { get; set; }
        public virtual Gouvernorat Gouvernorat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fournisseur> Fournisseur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Societe_assurance> Societe_assurance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Societe_maintenance> Societe_maintenance { get; set; }
    }
}