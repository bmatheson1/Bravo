using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ICorporateJargonGenerator _corporateJargonGenerator;

        public HomeController(ICorporateJargonGenerator corporateJargonGenerator)
        {
            _corporateJargonGenerator = corporateJargonGenerator;
        }

        public IActionResult Index()
        {
            var sentence = _corporateJargonGenerator.GetFluff();
            
            return View(new IndexModel(sentence));
        }
    }
}