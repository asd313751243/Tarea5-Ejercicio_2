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

        public static void actualizarProducto (Producto p,int id)
        {
            Productos[id].Nombre_producto = p.Nombre_producto;
            Productos[id].Descripcion_producto = p.Descripcion_producto;
            Productos[id].Fecha_venc_producto = p.Fecha_venc_producto;
            Productos[id].Id_proveedor = p.Id_proveedor;
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

        public static void actualizarProveedor(Proveedor p,int id)
        {
            Proveedores[id].Nombre_proveedor = p.Nombre_proveedor;
            Proveedores[id].Direccion_proveedor = p.Direccion_proveedor;
            Proveedores[id].Num_telef_proveedor = p.Num_telef_proveedor;
        }

    }
}
