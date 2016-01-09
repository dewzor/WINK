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
    public class ManageController : Controller
    {
        
        private ManageRepository _manageRepository;

        public ManageController()
        {
            _manageRepository = new ManageRepository();
        }

        // GET: Manage
        public ActionResult Index()
        {
            return View();
        }

        public new ActionResult Profile()
        {
            ProfileModel profile = new ProfileModel();
            var userid = Convert.ToInt32(Session["UserID"]);
            profile.about = _manageRepository.getPAboutById(userid);
            profile.hide = _manageRepository.getHide(userid);


            return View(profile);
        }
    }
}