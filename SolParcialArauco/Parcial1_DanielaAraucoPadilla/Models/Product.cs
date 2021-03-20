using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_DanielaAraucoPadilla.Models
{
    public class Product
    {
        [Key]
        [StringLength(99999, MinimumLength = 1, ErrorMessage= "Ingrese entre 1 a 99999 caracteres")]
        public string ProductID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Ingrese entre 1 a 30 caracteres")]
        public string Description { get; set; }
        [Required]
        public Currency Price { get; set; }
        public DateTime LastBuy { get; set; }
    }
}