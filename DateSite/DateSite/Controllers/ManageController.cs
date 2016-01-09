using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositories;
using DateSite.Functions;
using DateSite.Models;
using System.IO;

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

        [HttpPost]
        public new ActionResult Profile(Picture picture)
        {
            if (picture.File.ContentLength > 0)
            {
                var fileName = Path.GetFileName(picture.File.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/ProfileImages"), fileName);
                picture.File.SaveAs(path);
            }
            return RedirectToAction("Profile");
        }
    }
}