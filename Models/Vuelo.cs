using System.ComponentModel.DataAnnotations;

namespace VuelosCRUD.Models
{
  public class Vuelo
  {
    public int Id { get; set; }

    [StringLength(8)]
    [Display(Name = "Vuelo")]
    [Required(ErrorMessage = "El número de vuelo es obligatorio")]
    public string NumeroVuelo { get; set; }

    [Display(Name = "Horario LLegada")]
    [Required(ErrorMessage = "El horario de llegada es obligatorio")]
    public DateTime HorarioLLegada { get; set; }

    [StringLength(255)]
    [Display(Name = "Línea Aerea")]
    [Required(ErrorMessage = "La linea aerea es obligatoria")]
    public string LineaAerea { get; set; }
    public bool Demorado { get; set; }
  }
}
