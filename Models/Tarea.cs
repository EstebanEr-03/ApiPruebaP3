using System.ComponentModel.DataAnnotations;
namespace API_PRUEBA_PROGRESO3.Models

{
    public class Tarea
    {
        [Key]
        public int idTarea { get; set; }
        [Required]
        public string nombreTarea { get; set; }
        [Required]
        public string descripcionTarea { get; set; }
        [Required]
        public string estadoTarea { get; set; }
    }
}
