using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Choix_Restaurant.Models
{
    public class Resto
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        public string Telephone { get; set; }
    }
}