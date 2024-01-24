using System.ComponentModel.DataAnnotations;

namespace API_PRUEBA_PROGRESO3.Models
{
        public class Resultado
        {
            [Key]
            public int idUsuario { get; set; }
            [Required]
            public string nombre { get; set; }
            [Required]
            public bool resultado { get; set; }
            [Required]
            public int CantidadVictorias { get; set; }
            [Required]
            public DateTime fechaResultado { get; set; }


        }
}
