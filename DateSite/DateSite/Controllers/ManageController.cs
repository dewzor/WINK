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
            profile.visible = _manageRepository.getHide(userid);
            profile.userid = userid;
            profile.pic = _manageRepository.getPic(userid);

            return View(profile);
        }

        [HttpPost]
        public new ActionResult Profile(ProfileModel profile)
        {
            var userid = Convert.ToInt32(Session["UserID"]);
            if (profile.File != null && profile.File.ContentLength > 0)
            {
                var fileName = Path.GetFileName(profile.File.FileName);
                var parts = fileName.Split('.');
                fileName = userid + "." +parts[1];
                var path = Path.Combine(Server.MapPath("~/Content/ProfileImages"), fileName);
                profile.File.SaveAs(path);
                _manageRepository.setPic(userid, fileName);
            }
            var xa = profile.Aboutbox;
            var xs = profile.Visibility;
            _manageRepository.setPAboutById(userid, profile.Aboutbox);
            _manageRepository.setHide(userid, profile.Visibility);
            


            return RedirectToAction("Profile");
        }
    }
}