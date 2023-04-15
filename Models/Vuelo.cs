using System.ComponentModel.DataAnnotations;

namespace VuelosCRUD.Models
{
	public class Vuelo
	{
		public int Id { get; set; }

		[StringLength(8)]
		[Display(Name = "Vuelo")]
		public string NumeroVuelo { get; set; }

		[Display(Name = "Horario LLegada")]
		public DateTime HorarioLLegada { get; set; }

		[StringLength(255)]
		[Display(Name = "Línea Aerea")]
		public string LineaAerea { get; set; }
		public bool Demorado { get; set; }
	}
}
