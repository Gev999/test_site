using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstSite.Models;

namespace FirstSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Account account)
        {
            //if (ModelState.IsValid) return View();
            if (ModelState["Password"].ValidationState !=
                Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid
               && ModelState["Email"].ValidationState !=
               Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid) return View();

            return View("Index", account);
        }

        [HttpPost]
        public IActionResult Register()
        {
            if (ModelState.IsValid) return View();
            return View("Index");
        }
    }
}
