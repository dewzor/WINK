﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositories;


namespace DateSite.Models
{
    public class ProfileModel
    {
        public string about { get; set; }
        public string email { get; set; }
        public bool visible { get; set; }
        public string pic { get; set; }
        public int userid { get; set; }
        public HttpPostedFileBase File { get; set; }
        public string Aboutbox { get; set; }
        public bool Visibility { get; set; }

    }
}