using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UsersRepository
    {

        /// <summary>
        ///  Hämtar en user med viss id
        /// </summary>
        public List<Profiles> findProfilesByName(string name)
        {
            using (var context = new UserDBEntities())
            {
               
                context.Database.Connection.Open();
                List<Profiles> profile = (from a in context.Profiles
                                    where (a.Lastname.Contains(name) || a.Firstname.Contains(name))
                                    select a).ToList();
                return profile;
            }
        }

        /// <summary>
        /// Hämtar alla användare
        /// </summary>
        public List<Profiles> fetchProfiles()
        {
            using (var context = new UserDBEntities())
            {
                context.Database.Connection.Open();
                return context.Profiles.ToList();
            }
        }


        /// <summary>
        /// Lägger till en användare i databasen
        /// </summary>
        public void insertUser(Profiles profile, SECURITY security)
        {
            try
            {
                using (var context = new UserDBEntities())
                {
                    context.Database.Connection.Open();
                    context.Profiles.Add(profile);
                    context.SaveChanges();

                    security.PID = Int32.Parse(context.Profiles.Last().ToString());
                    context.SECURITY.Add(security);
                    
                }
            }
            catch 
            {

            }

        }


        public SECURITY loginUser(SECURITY user)
        {
            using (var context = new UserDBEntities())
            {
                context.Database.Connection.Open();
                SECURITY usr = null;
                try
                {
                     usr = context.SECURITY.Single(u => u.USERNAME == user.USERNAME && u.PASSWORD == user.PASSWORD);
                }
                catch
                {
                    usr = null;
                }

                return usr;
            }
            
        }

    }
}
