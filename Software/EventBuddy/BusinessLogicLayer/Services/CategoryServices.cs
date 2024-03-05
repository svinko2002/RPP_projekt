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

    public class CategoryServices
    {
        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public void addNewCategory(kategorija newCategory)
        {
            using (var repo = new CategoryRepository(new EventBuddyModel()))
            {
                repo.Add(newCategory);
            }
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public List<kategorija> getAllRequests()
        {
            using (var repo = new CategoryRepository(new EventBuddyModel()))
            {
                List<kategorija> requestsList = repo.GetAll().ToList();
                return requestsList;
            }
        }
    }
}
