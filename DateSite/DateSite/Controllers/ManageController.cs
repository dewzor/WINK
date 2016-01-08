﻿using System;
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
            var f = Session["UserID"];
            var s = Convert.ToInt32(f);
            var x = _manageRepository.getPAboutById(s);
            ViewBag.KORV = x;
            return View();
        }
    }
}