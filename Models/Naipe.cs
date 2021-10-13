using System.ComponentModel.DataAnnotations;

namespace NaipesWebAPI.Models
{
    public class Naipe
    {
        [Key]
        public string Nombre { get; set; }
        [Display(Name="Enlace de la Imagen")]
        public string Imagen { get; set; }
    }
}
