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


        public IActionResult Ver_producto()
        {
            return View();
        }

        public IActionResult Actualizar_producto()
        {
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


        public IActionResult Ver_proveedor()
        {
            return View();
        }

        public IActionResult Actualizar_proveedor()
        {
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
