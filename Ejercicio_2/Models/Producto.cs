using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    public class Producto
    {
        [Required]
        public int Id_producto { get; set; }
        [Required]
        public string Nombre_producto { get; set; }
        [Required]
        public string Descripcion_producto { get; set; }
        [Required]
        public DateTime Fecha_venc_producto { get; set; }
        [Required]
        public int Id_proveedor { get; set; }
    }
}
