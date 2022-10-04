using System.ComponentModel.DataAnnotations;

namespace RegistroAportes.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage ="El Nombre es obligatorio")]
        public string? Persona { get; set; }
        [Required(ErrorMessage ="La Observacion es obligatoria")]
        public string? Observacion { get; set; }
        [Range(minimum:50, maximum:500000, ErrorMessage ="Introduzca un Monto entre el rango de 50 a 500,000")]
        public int Monto { get; set; }
    }
}