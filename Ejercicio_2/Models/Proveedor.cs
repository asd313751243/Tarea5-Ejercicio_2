using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    public class Proveedor
    {
        [Required]
        public int Id_proveedor { get; set; }
        [Required]
        public string Nombre_proveedor { get; set; }
        [Required]
        public string Direccion_proveedor { get; set; }
        [Required]
        [StringLength(10)]
        public string Num_telef_proveedor { get; set; } 
    }
}
