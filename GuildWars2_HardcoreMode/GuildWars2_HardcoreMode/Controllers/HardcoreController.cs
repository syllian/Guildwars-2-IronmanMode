using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuildWars2_HardcoreMode.Models;

namespace GuildWars2_HardcoreMode.Controllers
{
    public class HardcoreController : Controller
    {
        // GET: Hardcore
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult postStartHMGame(String APIkey)
        {
            var character = new Character();
            return View(character);
        }

        [HttpPost]
        public void postEndHMGame(String APIkey)
        {

        }

        [HttpPost]
        public void addHMChracter(String APIkey, String CharacterName)
        {

        }

    }
}