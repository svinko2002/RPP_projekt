using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    /// <summary>
    /// <author>Sebastijan Vinko</author>
    /// </summary>
    public class RequestOrganizerRepository : Repository<zahtjev_organizator>
    {
        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public RequestOrganizerRepository(EventBuddyModel context) : base(context)
        {
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public void acceptOrganizerRequest(zahtjev_organizator selectedRequst)
        {
            selectedRequst.prihvacen = true;
            Entities.AddOrUpdate(selectedRequst);
            SaveChanges();
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public void declineOrganizerRequest(zahtjev_organizator selectedRequst)
        {
            Remove(selectedRequst);
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public override IQueryable<zahtjev_organizator> GetAll()
        {
            var query = from e in Entities.Include("korisnik")
                        select e;
            return query;
        }
    }
}
