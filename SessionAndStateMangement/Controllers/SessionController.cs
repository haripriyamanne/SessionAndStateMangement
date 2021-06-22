using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionAndStateMangement.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            string name = HttpContext.Session.GetString("Name");
            return View(model: name);
        }

        public IActionResult SaveName(string name)
        {
            HttpContext.Session.SetString("Name", name);
            return RedirectToAction("Index");
        }
    }
}
