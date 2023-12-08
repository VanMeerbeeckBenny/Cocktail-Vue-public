using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Pri.Cocktails.Vue.Web.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            string role = Request.Cookies.FirstOrDefault(k => k.Key == "role").Value;
            if (role != "admin") return View("Acces_denied");
            return View();
        }
    }
}
