using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Perro:Animal
    {
        [Required]
        public string Raza { get; set; }
        [Required]
        public string Size { get; set; }
    }
}
