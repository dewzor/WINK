using System;
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
        public bool hide { get; set; }
        public string pic { get; set; }
    }
}