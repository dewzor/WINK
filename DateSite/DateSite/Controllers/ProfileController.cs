using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositories;
using DateSite.Functions;
using DateSite.Models;

namespace DateSite.Controllers
{
    public class ProfileController : Controller
    {


        private UsersRepository _usersRepository;

        public ProfileController()
        {
            _usersRepository = new UsersRepository();
        }

        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }


    }
}