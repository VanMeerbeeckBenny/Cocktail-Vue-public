using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Pri.Cocktails.Vue.Web.Controllers
{
    public class IngredientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IngredientsFromUserIndex()
        {          
            return View();
        }

        public IActionResult Update([FromRoute]int id)
        {   
            ViewBag.id = id;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
