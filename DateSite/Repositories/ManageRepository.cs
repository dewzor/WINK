using System;
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


    }
}
