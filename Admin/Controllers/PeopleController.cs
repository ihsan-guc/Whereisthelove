using Admin.Core;
using Admin.Models.PeopleViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Whereisthelove.Data.Domain.Entities;
using X.PagedList;
namespace Admin.Controllers
{
    [Authorize]
    [Route("People")]
    public class PeopleController : BaseController
    {

        [Route("Index")]
        public IActionResult Index(int? page)
        {
            var pagenumber = page ?? 1;
            int pagesize = 3;
            var model = new PeopleHomeViewModel()
            {
                PagedList = UnitOfWork.PeopleRepository.GetQueryable().ToPagedList(pagenumber, pagesize)
            };
            return View(model);
        }
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed(PeopleCEViewModel model)
        {
            if (ModelState.IsValid)
            {
                var People = new People()
                {
                    Id = Guid.NewGuid(),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Image = await FileManager.FileImageSaveAsync(model.Image),
                    Description = model.Description,
                    Detail = model.Detail,
                    News = model.News,
                    Title = model.Title
                };
                UnitOfWork.PeopleRepository.Add(People);
                UnitOfWork.Commit();
                return RedirectToAction("Index", "People");
            }
            return View();
        }
        [Route("Edit")]
        public IActionResult Edit(Guid id)
        {
            var model = UnitOfWork.PeopleRepository.GetById(id);
            var People = new PeopleCEViewModel()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                ImagePath = model.Image,
                Description = model.Description,
                Detail = model.Detail,
                News = model.News,
                Title = model.Title
            };
            return View(People);
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> EditConfirmed(PeopleCEViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = UnitOfWork.PeopleRepository.GetById(model.Id);
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                FileManager.ImageDelete(model.ImagePath);
                entity.Image = await FileManager.FileImageSaveAsync(model.Image);
                entity.Title = model.Title;
                entity.News = model.News;
                entity.Detail = model.Detail;
                entity.Description = model.Description;
                UnitOfWork.Commit();
                return RedirectToAction("Index", "People");
            }
            return View();
        }

        [Route("Details")]
        public IActionResult Details(Guid id)
        {
            var entity = UnitOfWork.PeopleRepository.GetById(id);
            return View(entity);
        }

        [Route("PeopleDelete")]
        public IActionResult PeopleDelete(Guid id)
        {
            var entity = UnitOfWork.PeopleRepository.GetById(id);
            return View(entity);
        }

        [HttpPost]
        [Route("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var entity = UnitOfWork.PeopleRepository.GetById(id);
            FileManager.ImageDelete(entity.Image);
            UnitOfWork.PeopleRepository.Delete(entity);
            UnitOfWork.Commit();
            return RedirectToAction("Index", "People");
        }

    }
}
