using Ejercicio_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    public class CRUD
    {

        public static List<Producto> Productos { get; } = new List<Producto>();
        public static List<Proveedor> Proveedores { get; } = new List<Proveedor>();

        public static void agregarProducto (Producto p)
        {
            if(Productos.Count > 0)
            {
                p.Id_producto = Productos.Count;
            }
            else if(Productos.Count == 0)
            {
                p.Id_producto = 0;
            }

            Productos.Add(p);
        }

        public static void agregarProveedor(Proveedor p)
        {
            if (Proveedores.Count > 0)
            {
                p.Id_proveedor = Proveedores.Count;
            }
            else if(Proveedores.Count == 0)
            {
                p.Id_proveedor = 0;
            }

            Proveedores.Add(p);
        }

    }
}
