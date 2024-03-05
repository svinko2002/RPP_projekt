using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : Repository<kategorija>
    {
        public CategoryRepository(EventBuddyModel context) : base(context)
        {
        }

        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public override int Add(kategorija entity, bool saveChanges = true)
        {
            var exists = Entities.FirstOrDefault(x => x.naziv == entity.naziv);
            if (exists == null)
            {
                Entities.Add(entity);
            }

            return saveChanges ? SaveChanges() : 0;
        }
        /// <summary>
        /// <author>Karlo Mikec</author>
        /// </summary>
        public int Update(kategorija entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
