using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MLS_Morales_DeLeon.Models
{
    public class RutaArchivo
    {
        [Required]
        public string ruta { get; set; }
    }
}
