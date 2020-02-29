using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio_2.Models;

namespace Ejercicio_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Vistas para producto---------------------------------------------------------------------------------

        public IActionResult Agregar_producto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar_producto(Producto a)
        {
            if (ModelState.IsValid)
            {
                CRUD.agregarProducto(a);
                return RedirectToAction("Ver_producto");
            }
                
            return View();
        }


        public IActionResult Ver_producto()
        {
            return View();
        }


        public IActionResult Actualizar_producto(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        [HttpPost]
        public IActionResult Actualizar_producto(Producto a,int id)
        {
            if (ModelState.IsValid)
            {
                CRUD.actualizarProducto(a,id);
                return RedirectToAction("Ver_producto");
            }
            return View();
        }

        public IActionResult Eliminar_producto()
        {
            return View();
        }

        //Vistas para proveedor---------------------------------------------------------------------------------


        public IActionResult Agregar_proveedor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar_proveedor(Proveedor a)
        {
            if (ModelState.IsValid)
            {
                CRUD.agregarProveedor(a);
                return RedirectToAction("Ver_proveedor");
            }

            return View();
        }

        public IActionResult Ver_proveedor()
        {
            return View();
        }

        public IActionResult Actualizar_proveedor(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        [HttpPost]
        public IActionResult Actualizar_proveedor(Proveedor a,int id)
        {
            if (ModelState.IsValid)
            {
                CRUD.actualizarProveedor(a,id);
                return RedirectToAction("Ver_proveedor");
            }
            return View();
        }

        public IActionResult Eliminar_proveedor()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
