using Admin.Models.HomePageViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Admin.Controllers
{
    public class AnasayfaController : BaseController
    {
        public IActionResult Index(int year = 2021)
        {
            HomePageViewModel model = new HomePageViewModel()
            {
                DeathDateList = UnitOfWork.DeathDateRepository.GetQueryable().OrderByDescending(p=>p.Year).ToList(),
                PeopleList = UnitOfWork.PeopleRepository.GetQueryable().Where(p => p.DeathDate.Year == year).ToList()
            };
            return View(model);
        }
        public IActionResult SinglePage(Guid Id)
        {
            HomePageViewModel model = new HomePageViewModel()
            {
                DeathDateList = UnitOfWork.DeathDateRepository.GetQueryable().OrderByDescending(p => p.Year).ToList(),
                PeopleList = UnitOfWork.PeopleRepository.GetQueryable().Where(p => p.Id == Id).ToList()
            };
            return View(model);
        }
    }
}
