﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tattoo_Shop.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Naam { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public Decimal? Prijs { get; set; }
        [Required]
        public string Foto { get; set; }

        public string Descriptie { get; set; }

        public string Merk { get; set; }
    }
}
