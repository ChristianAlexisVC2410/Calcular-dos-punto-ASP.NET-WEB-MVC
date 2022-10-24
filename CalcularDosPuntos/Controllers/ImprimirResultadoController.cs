using CalcularDosPuntos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalcularDosPuntos.Controllers
{
    public class ImprimirResultadoController : Controller
    {
        // GET: ImprimirResultado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Imprimir()
        {
         
            string resultado = "";
            string x1 = "";
            string x2 = "";
            string y1 = "";
            string y2 = "";
            if (TempData.ContainsKey("resultado"))
            {
                resultado = TempData["resultado"].ToString();
            }
            if (TempData.ContainsKey("X1"))
            {
                x1 = TempData["X1"].ToString();
            }
            if (TempData.ContainsKey("X2"))
            {
                x2 = TempData["X2"].ToString();
            }
            if (TempData.ContainsKey("Y1"))
            {
                y1 = TempData["Y1"].ToString();
            }
            if (TempData.ContainsKey("Y2"))
            {
                y2 = TempData["Y2"].ToString();
            }
            Puntos p = new Puntos()
            {
                X1=Convert.ToDouble(x1),
                Y1=Convert.ToDouble(y1),
                X2=Convert.ToDouble(x2),
                Y2=Convert.ToDouble(y2),
                Result = Convert.ToDouble(resultado)
            };

            ViewBag.Puntos = p;

            return View();
        }
    }
}