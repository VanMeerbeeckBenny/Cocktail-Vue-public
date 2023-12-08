using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Pri.Cocktails.Vue.Web.Controllers
{
    public class GlassTypesController : Controller
    {
        public IActionResult Index()
        {
            string role = Request.Cookies.FirstOrDefault(k => k.Key == "role").Value;
            if (role != "admin") return View("Acces_denied");
            return View();
        }

        public IActionResult Create()
        {
            string role = Request.Cookies.FirstOrDefault(k => k.Key == "role").Value;
            if (role != "admin") return View("Acces_denied");
            return View();
        }

        public IActionResult Update([FromRoute] int id)
        {

            string role = Request.Cookies.FirstOrDefault(k => k.Key == "role").Value;
            if (role != "admin") return View("Acces_denied");
            ViewBag.id = id;
            return View(id);
        }
    }
}
