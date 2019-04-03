using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tic_BigSchool.Models;
using Microsoft.AspNet.Identity;

namespace Tic_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // GET: Courses
        [Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModels viewModels)
        {
            if(!ModelState.IsValid)
            {
                viewModels.Categories = _dbContext.CateGories.ToList();
                return View("Create", viewModels);
            }
            var course = new Course
            {
                LecturerId=User.Identity.GetUserId(),
                DateTime=viewModels.GetDateTime(),
                CategoryId=viewModels.Category,
                Place=viewModels.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}