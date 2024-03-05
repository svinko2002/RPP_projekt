using DataAccessLayer.Repositories;
using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class RequestCategoryServices
    {
        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public List<zahtjev_kategorija> getAllRequests()
        {
            using (var repo = new RequestCategoryRepository(new EventBuddyModel()))
            {
                List<zahtjev_kategorija> requestsList = repo.GetAll().ToList();
                return requestsList;
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public void acceptCategoryRequest(zahtjev_kategorija selectedRequst)
        {
            using (var repo = new EventBuddyModel())
            {
                repo.zahtjev_kategorija.Attach(selectedRequst);
                repo.zahtjev_kategorija.Remove(selectedRequst);
                var category = new kategorija
                {
                    naziv = selectedRequst.naslov.ToString()
                };
                var exists = repo.kategorija.FirstOrDefault(x => x.naziv == selectedRequst.naslov);
                if(exists == null)
                {
                    repo.kategorija.Add(category);
                }
                repo.SaveChanges();
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public void declineCategoryRequest(zahtjev_kategorija selectedRequst)
        {
            using (var repo = new RequestCategoryRepository(new EventBuddyModel()))
            {
                repo.declineCategoryRequest(selectedRequst);
            }
        }
    }
}
