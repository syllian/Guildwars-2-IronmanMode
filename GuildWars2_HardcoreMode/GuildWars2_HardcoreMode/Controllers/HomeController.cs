using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuildWars2_HardcoreMode.Models;

namespace GuildWars2_HardcoreMode.Controllers
{
    public class HomeController : Controller
    {
        Account account;

        public ActionResult Index()
        {
            account = account ?? new Account();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(account);
        }

        [HttpPost]
        public ActionResult About(Account account)
        {
            this.account = account;
            return RedirectToAction("Contact");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}