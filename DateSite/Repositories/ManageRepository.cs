﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ManageRepository
    {
        public string getPAboutById(int id)
        {
            using (var context = new UserDBEntities())
            {
                var about = (from a in context.Profiles
                            where (a.Id == id)
                            select a.About).Single();
                return about;
            }
        }

        public bool getHide(int id)
        {
            using (var context = new UserDBEntities())
            {
                var hide = (from a in context.SECURITY
                             where (a.PID == id)
                             select a.VISIBILITY).SingleOrDefault();
                return hide;
            }
        }

        public void setHide(int id, int choice)
        {
            using (var context = new UserDBEntities())
            {
                var hide = (from a in context.SECURITY
                             where (a.PID == id)
                             select a).SingleOrDefault();
                if (choice == 1)
                    hide.VISIBILITY = true;
                if (choice == 0)
                    hide.VISIBILITY = false;
                context.SaveChanges();
            }
        }

    }
}
