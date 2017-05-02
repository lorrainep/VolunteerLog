using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volun.Models;
using Volun.Services;

namespace Volun.Web.Controllers
{
    [Authorize]
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new LogService(userId);
            var model = service.GetLogs();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LogCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            };

            

            var service = CreateLogService();//create note service is refactored

            if (service.CreateLog(model))
            {
                TempData["SaveResult"] = "Your logs were updated successfully.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Your logs could not be updated.");

            return View(model);

            
        }

        public ActionResult Details(int id)
        {
            var service = CreateLogService();
            var model = service.GetLogById(id);

            return View(model);
        }

        private LogService CreateLogService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new LogService(userId);
            return service;
        }
    }
}