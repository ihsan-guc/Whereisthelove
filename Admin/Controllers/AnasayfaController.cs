using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Admin.Controllers
{
    public class AnasayfaController : BaseController
    {
        public IActionResult Index()
        {
            var model = UnitOfWork.PeopleRepository.GetQueryable().ToList();
            return View(model);
        }

        public IActionResult SinglePage()
        {
            return View();
        }
    }
}
