using CalcularDosPuntos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalcularDosPuntos.Controllers
{
    public class RecibirController : Controller
    {
        // GET: Recibir
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RecibirFormulario()
        {
            Puntos p = new Puntos();
            return View(p);// no es necesario la p
        }


        [HttpPost]
        public ActionResult RecibirFormulario(Puntos p)
        {
           
            p.CalcularPuntos();
            TempData["X1"] = p.X1;
            TempData["Y1"] = p.Y1;

            TempData["X2"] = p.X2;
            TempData["Y2"] = p.Y2;
            TempData["resultado"] = p.Result;
            return RedirectToAction("Imprimir", "ImprimirResultado");
        }

  
    }
}