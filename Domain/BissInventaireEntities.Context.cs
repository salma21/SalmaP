﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BissInventaireEntities : DbContext
    {
        private static BissInventaireEntities instance;
        public static BissInventaireEntities Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BissInventaireEntities();
                }
                return instance;
            }
        }

        public BissInventaireEntities()
            : base("name=BissInventaireEntities")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Achat> Achat { get; set; }
        public virtual DbSet<Association_30> Association_30 { get; set; }
        public virtual DbSet<Association_31> Association_31 { get; set; }
        public virtual DbSet<AtbDataTest> AtbDataTest { get; set; }
        public virtual DbSet<Batiment> Batiment { get; set; }
        public virtual DbSet<Bien> Bien { get; set; }
        public virtual DbSet<Bureau> Bureau { get; set; }
        public virtual DbSet<Categorie_materiel> Categorie_materiel { get; set; }
        public virtual DbSet<CategorieDesignation> CategorieDesignation { get; set; }
        public virtual DbSet<Cipherlab> Cipherlab { get; set; }
        public virtual DbSet<Contrat_assurance> Contrat_assurance { get; set; }
        public virtual DbSet<Contrat_garanti> Contrat_garanti { get; set; }
        public virtual DbSet<Contrat_maintenance> Contrat_maintenance { get; set; }
        public virtual DbSet<Delegation> Delegation { get; set; }
        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<Etage> Etage { get; set; }
        public virtual DbSet<Fournisseur> Fournisseur { get; set; }
        public virtual DbSet<Gouvernorat> Gouvernorat { get; set; }
        public virtual DbSet<Inventaire> Inventaire { get; set; }
        public virtual DbSet<Mouvement> Mouvement { get; set; }
        public virtual DbSet<Organisation> Organisation { get; set; }
        public virtual DbSet<Parc_auto> Parc_auto { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<ServiceD> ServiceD { get; set; }
        public virtual DbSet<Societe_assurance> Societe_assurance { get; set; }
        public virtual DbSet<Societe_maintenance> Societe_maintenance { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
        public virtual DbSet<Vehicule> Vehicule { get; set; }
    }
}
