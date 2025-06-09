using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Gato:Animal
    {
        [Required]
        public string Pelaje { get; set; }
        [Required]
        public string EsDomestico { get; set; }
    }
}
