//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Commentaire
    {
        [DisplayName("Identifiant du commentaire")]
        [Required(ErrorMessage = "Obligatoire.")]
        public string identifiantCommentaire { get; set; }

        [DisplayName("Objet")]
        [Required(ErrorMessage = "Obligatoire.")]
        public string objet { get; set; }

        [DisplayName("Votre commentire")]
        [Required(ErrorMessage = "Obligatoire.")]
        public string texte { get; set; }

        [DisplayName("Votre nom")]
        [Required(ErrorMessage = "Obligatoire.")]
        public string propriétaire { get; set; }

        [DisplayName("Date")]
        [Required(ErrorMessage = "Obligatoire.")]
        public System.DateTime date { get; set; }

        [DisplayName("Votre courriel")]
        [Required(ErrorMessage = "Obligatoire.")]
        public string courriel { get; set; }

        [DisplayName("Votre numéro de téléphone")]
        public Nullable<decimal> telephone { get; set; }
    }
}