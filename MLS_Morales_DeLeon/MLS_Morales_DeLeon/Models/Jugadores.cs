using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MLS_Morales_DeLeon.Models
{
    public class Jugadores
    {
        [Required]
        public string EquipoMLS { get; set; }
        [Required]
        public string NombreJugador { get; set; }
        public string Posicion { get; set; }
        public int Salario { get; set; }

        public int Id { get; set; }
    }
}
