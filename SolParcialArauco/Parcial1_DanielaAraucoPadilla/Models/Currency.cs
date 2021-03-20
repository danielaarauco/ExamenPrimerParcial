using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_DanielaAraucoPadilla.Models
{
    public class Currency
    {
        [Key]
        public string Code { get; set; }
        [Required]
        public double Name { get; set; }
        [Required]
        [StringLength(5,MinimumLength = 1, ErrorMessage = "ingrese de 1 a 5 caracteres")]
        public string Symbol { get; set; }

    }
}