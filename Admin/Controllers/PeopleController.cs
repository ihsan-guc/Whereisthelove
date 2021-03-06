﻿using Admin.Models.PeopleViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Threading.Tasks;
using Whereisthelove.Data.Domain.Entities;
using X.PagedList;

namespace Admin.Controllers
{
    [Authorize]
    [Route("People")]
    [Authorize]
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
            ViewBag.DeathDate = UnitOfWork.DeathDateRepository.GetQueryable().OrderByDescending(p=>p.Year)
                .Select(a => new SelectListItem() { Value = a.Id.ToString(), Text = a.Year.ToString()}).ToList();
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
                    Description = model.Description,
                    Detail = model.Detail,
                    News = model.News,
                    Title = model.Title,
                    DeathDateId = model.DeathDateId,
                    ByWhom = model.ByWhom,
                    WhyKilled = model.WhyKilled,
                    PlaceDeath = model.PlaceDeath,
                    Subject = model.Subject,
                    IsProtection = model.IsProtection,
                    SourceLink = model.SourceLink,
                    WayKilled = model.WayKilled
                };
                People.Image = await FileManager.FileImageSaveAsync(model.Image);
                UnitOfWork.PeopleRepository.Add(People);
                UnitOfWork.Commit();
                return RedirectToAction("Index", "People");
            }
            ViewBag.DeathDate = UnitOfWork.DeathDateRepository.GetQueryable().OrderBy(p => p.Year)
                .Select(a => new SelectListItem() { Value = a.Id.ToString(), Text = a.Year.ToString() }).ToList();
            return View();
        }
        [Route("Edit")]
        public IActionResult Edit(Guid id)
        {
            var model = UnitOfWork.PeopleRepository.GetById(id);
            ViewBag.DeathDate = UnitOfWork.DeathDateRepository.GetQueryable().OrderBy(p => p.Year)
                .Select(a => new SelectListItem() { Value = a.Id.ToString(), Text = a.Year.ToString() }).ToList();
            var People = new PeopleCEViewModel()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Description = model.Description,
                Detail = model.Detail,
                News = model.News,
                Title = model.Title,
                DeathDateId = model.DeathDateId,
                ByWhom = model.ByWhom,
                WhyKilled = model.WhyKilled,
                PlaceDeath = model.PlaceDeath,
                Subject = model.Subject,
                IsProtection = model.IsProtection,
                SourceLink = model.SourceLink,
                WayKilled = model.WayKilled
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
                entity.DeathDateId = model.DeathDateId;
                entity.ByWhom = model.ByWhom;
                entity.WhyKilled = model.WhyKilled;
                entity.PlaceDeath = model.PlaceDeath;
                entity.Subject = model.Subject;
                entity.IsProtection = model.IsProtection;
                entity.SourceLink = model.SourceLink;
                entity.WayKilled = model.WayKilled;
                UnitOfWork.Commit();
                return RedirectToAction("Index", "People");
            }
            ViewBag.DeathDate = UnitOfWork.DeathDateRepository.GetQueryable().OrderBy(p => p.Year)
                .Select(a => new SelectListItem() { Value = a.Id.ToString(), Text = a.Year.ToString() }).ToList();
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
