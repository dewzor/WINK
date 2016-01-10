using DateSite.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DateSite.Controllers
{
    public class HomeController : Controller
    {
        UsersRepository _usersRepository = new UsersRepository();
        BrowseModel data = new BrowseModel();

        public ActionResult Index()
        {
            data.randomProfiles = _usersRepository.getRandomProfiles();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}