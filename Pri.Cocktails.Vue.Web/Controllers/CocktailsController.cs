using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Pri.Cocktails.Vue.Web.Controllers
{
    public class CocktailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details([FromRoute] string id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult CocktailsOfUserIndex()
        {
            return View();
        }

        public IActionResult Create() 
        {
            return View(); 
        }

        public IActionResult Update([FromRoute] string id)
        {
            ViewBag.Id = id;
            return View();
        }

    }
}
