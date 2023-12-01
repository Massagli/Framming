using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Framming.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult Register()
        {

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult cad_func()
        {

            return View();
        }
        public ActionResult alterar_cad()
        {

            return View();
        }
        public ActionResult administrador()
        {
          
            return View();
        }
        public ActionResult verpostadm()
        {

            return View();
        }
        public ActionResult Cad_cinema()
        {

            return View();
        }
        public ActionResult Alterar_cinema()
        {

            return View();
        }
        public ActionResult Usuarios()
        {

            return View();
        }
        public ActionResult pesquisacinema()
        {

            return View();
        }
        public ActionResult pesquisafunc()
        {

            return View();
        }
    }
}