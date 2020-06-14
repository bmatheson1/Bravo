using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ICorporateJargonGenerator _corporateJargonGenerator;

        public HomeController()
        {
            _corporateJargonGenerator = new CorporateJargonGenerator();
        }

        public IActionResult Index()
        {
            var sentence = _corporateJargonGenerator.GetFluff();
            
            return View(new IndexModel(sentence));
        }
    }
}