﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetChatem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdchatemEntities : DbContext
    {
        public bdchatemEntities()
            : base("name=bdchatemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actualite> Actualites { get; set; }
        public virtual DbSet<Commentaire> Commentaires { get; set; }
        public virtual DbSet<EtatProjet> EtatProjets { get; set; }
        public virtual DbSet<Evenement> Evenements { get; set; }
        public virtual DbSet<FoireAuxQuestion> FoireAuxQuestions { get; set; }
        public virtual DbSet<Partenaire> Partenaires { get; set; }
        public virtual DbSet<Projet> Projets { get; set; }
        public virtual DbSet<Repertoire> Repertoires { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TypeUtilisateur> TypeUtilisateurs { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<UtilisateurEvenement> UtilisateurEvenements { get; set; }
    }
}
