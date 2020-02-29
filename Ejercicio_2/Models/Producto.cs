using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    public class Producto
    {
        public int Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion_producto { get; set; }
        public DateTime Fecha_venc_producto { get; set; }

        public int Id_proveedor { get; set; }
    }
}
