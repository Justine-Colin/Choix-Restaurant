using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Choix_Restaurant.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        [Required]
        public string Prenom { get; set; }
    }
}