﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Ave:Animal
    {
        [Required]
        public string TipoPico { get; set; }
        [Required]
        public string Vuela { get; set; }
    }
}
