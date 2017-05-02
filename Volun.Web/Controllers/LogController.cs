using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volun.Models;

namespace Volun.Web.Controllers
{
    [Authorize]
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult Index()
        {
            var model = new LogItem[0];
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
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}