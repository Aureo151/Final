using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Animal
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Especie { get; set; }
        [Required]
        public int Edad {  get; set; } 
    }
}
