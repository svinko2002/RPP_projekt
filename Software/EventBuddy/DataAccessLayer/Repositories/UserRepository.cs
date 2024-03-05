using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : Repository<korisnik>
    {
        public UserRepository(EventBuddyModel context) : base(context)
        {
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public override IQueryable<korisnik> GetAll()
        {
            var query = from e in Entities.Include("dogadaj").Include("zahtjev_organizator").Include("zahtjev_kategorija")
                        select e;
            return query;
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public korisnik loginUser(string username, string password)
        {
            var user = Entities.SingleOrDefault(u => u.korime == username && u.lozinka == password);
            return user;
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public int Update(korisnik entity, bool saveChanges = true)
        {
            var user = Entities.First(e => e.ID == entity.ID);
            if (user != null)
            {
                user.lozinka = entity.lozinka;
            }
            return saveChanges ? SaveChanges() : 0;
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int warnUser(int userID, bool saveChanges = true)
        {
            var user = Entities.SingleOrDefault(d => d.ID == userID);
            if(user.upozorenja == 1 || user.upozorenja == -1)
            {
                user.upozorenja = 2;
                revokeOrganizerRole(userID);
            }
            if (user.upozorenja == 0)
            {
                user.upozorenja = 1;
            }
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int revokeOrganizerRole(int userID, bool saveChanges = true)
        {
            return revokeRole(userID, "Organizator");
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int revokeModRole(int userID, bool saveChanges = true)
        {
            return revokeRole(userID, "Moderator");
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int revokeRole(int userID, string roleName, bool saveChanges = true)
        {
            var user = Entities.SingleOrDefault(d => d.ID == userID);
            var uloga = user.uloga.FirstOrDefault(x => x.Naziv == roleName) as uloga;
            if (uloga != null)
            {
                user.uloga.Remove(uloga);

                if (saveChanges)
                {
                    return SaveChanges();
                }
            }
            return 0;
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public bool checkForOrganizerRole(korisnik selectedUser)
        {
            return checkForRole("Organizator", selectedUser);
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public bool checkForModRole(korisnik selectedUser)
        {
            return checkForRole("Moderator", selectedUser);
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public bool checkForAdminRole(korisnik selectedUser)
        {
            return checkForRole("Administrator", selectedUser);
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public bool checkForRole(string roleName, korisnik selectedUser)
        {
            var user = Entities.SingleOrDefault(d => d.ID == selectedUser.ID);

            if (user != null && user.uloga.Any(x => x.Naziv == roleName))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public List<prijevodi> getTranslations(korisnik user)
        {
            using (var context = new EventBuddyModel())
            {
                var translations = new List<prijevodi>();
                var selectedUser = Entities.SingleOrDefault(u => u.korime == user.korime);
                if (selectedUser.jezik.Count() > 0)
                {
                    var language = selectedUser.jezik.ToList()[0];
                    translations = context.prijevodi.ToList().FindAll(x => x.ID_jezika == language.ID);
                }
                return translations;
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public List<jezik> getLanguages()
        {
            using (var context = new EventBuddyModel())
            {
                return context.jezik.ToList();
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public void setUserLanguage(korisnik user, jezik language)
        {
            using (var context = new EventBuddyModel())
            {
                var selectedUser = context.korisnik.SingleOrDefault(u => u.korime == user.korime);
                var selectedLanguage = context.jezik.SingleOrDefault(u => u.ID == language.ID);
                selectedUser.jezik.Clear();
                selectedUser.jezik.Add(selectedLanguage);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public jezik getUserLanguage(korisnik user)
        {
            using (var context = new EventBuddyModel())
            {
                var selectedUser = context.korisnik.SingleOrDefault(u => u.korime == user.korime);
                if (selectedUser.jezik.Count() > 0)
                {
                    return selectedUser.jezik.ToArray()[0];
                }

                return context.jezik.ToList().Find(x => x.naziv == "Hrvatski");
            }
        }
    }
}
