using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ventas2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public JsonResult ObtenerProductos()
        {
            var listProducto = new List<Models.producto>();
            var produ1 = new Models.producto() { IdpOrducto = 1, NombrewProducto = "peras", Precio = 12 };
            var produ2 = new Models.producto() { IdpOrducto = 1, NombrewProducto = "manzanas", Precio = 12 };
            var produ3 = new Models.producto() { IdpOrducto = 1, NombrewProducto = "kiwi", Precio = 12 };

            listProducto.Add(produ1);
            listProducto.Add(produ2);
            listProducto.Add(produ3);

            return Json(listProducto, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ObtenerUsuarios()
        {
            var ListCargo = new List<Models.tipoUsuario>();
            var tu1 = new Models.tipoUsuario(){idTipoUsuario = 1, cargo = "Administrador"};
            var tu2 = new Models.tipoUsuario(){idTipoUsuario = 2, cargo = "operario"};
            ListCargo.Add(tu1);
            ListCargo.Add(tu2);
            var listProducto = new List<Models.usuario>();
            var u1 = new Models.usuario() { idUsuario = 1, nombre = "Juancho",apellido="Vayl oyo", login = "juancho" ,password="123", cargo=ListCargo};
            var u2 = new Models.usuario() { idUsuario = 1, nombre = "Pedro", apellido = "Chancleto", login = "pedro", password = "123", cargo = ListCargo };
            var u3 = new Models.usuario() { idUsuario = 1, nombre = "Mario", apellido = "Chapu Son", login = "mario", password = "123", cargo = ListCargo };

            listProducto.Add(u1);
            listProducto.Add(u2);
            listProducto.Add(u3);

            return Json(listProducto, JsonRequestBehavior.AllowGet);
        }
    }

    
}
