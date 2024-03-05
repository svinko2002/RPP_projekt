using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RoleRepository : Repository<uloga>
    {

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public RoleRepository(EventBuddyModel context) : base(context)
        {
        }
    }
}
