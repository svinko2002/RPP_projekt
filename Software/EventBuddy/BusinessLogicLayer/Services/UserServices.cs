using DataAccessLayer.Repositories;
using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BusinessLogicLayer.Services
{
    public class UserServices
    {
        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int warnUser(int userID)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.warnUser(userID);
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int revokeOrganizerRole(int userID)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.revokeOrganizerRole(userID);
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int revokeModRole(int userID)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.revokeModRole(userID);
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int addOrganizerRole(int userID)
        {
            using (var context = new EventBuddyModel())
            {
                var user = (from e in context.korisnik
                             select e).FirstOrDefault(r => r.ID == userID);

                var role = (from e in context.uloga
                             select e).FirstOrDefault(u => u.Naziv == "Organizator");

                user.uloga.Add(role);
                return context.SaveChanges();
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int addModRole(int userID)
        {
            using (var context = new EventBuddyModel())
            {
                var user = (from e in context.korisnik
                            select e).FirstOrDefault(r => r.ID == userID);

                var role = (from e in context.uloga
                            select e).FirstOrDefault(u => u.Naziv == "Moderator");

                user.uloga.Add(role);
                return context.SaveChanges();
            }
        }
        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public List<korisnik> getAllUsers()
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                List<korisnik> userList = repo.GetAll().ToList();
                return userList;
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public korisnik loginUser(string username, string password)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                var user = repo.loginUser(username, password);
                return user;
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public bool checkForOrganizerRole(korisnik user)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.checkForOrganizerRole(user);
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public bool checkForModRole(korisnik selectedUser)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.checkForModRole(selectedUser);
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        /// <param name="selectedUser"></param>
        /// <returns></returns>
        public bool checkForAdminRole(korisnik selectedUser)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.checkForAdminRole(selectedUser);
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public bool updateUser(korisnik user)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.Update(user) > 0;
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public List<prijevodi> getUserTranslations(korisnik user)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.getTranslations(user);
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public List<jezik> getLanguages()
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.getLanguages();
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public void setUserLanguage(korisnik user, jezik language)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                repo.setUserLanguage(user, language);
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public jezik getUserLanguage(korisnik user)
        {
            using (var repo = new UserRepository(new EventBuddyModel()))
            {
                return repo.getUserLanguage(user);
            }
        }
    }
}
