using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EventRepository : Repository<dogadaj>
    {
        public EventRepository(EventBuddyModel context) : base(context)
        {
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public override IQueryable<dogadaj> GetAll()
        {
            var query = from e in Entities.Include("status").Include("korisnik").Include("kategorija")
                        select e;
            return query;
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int hideEvent(dogadaj entity, bool saveChanges = true)
        {
            var selectedEvent = Entities.SingleOrDefault(d => d.ID == entity.ID);
            selectedEvent.ID_status = 5;

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
        /// <author>Dominik Josipović</author>
        /// </summary>
        public IQueryable<string> GetLocations()
        {
            var query = from e in Entities select e.mjesto;
            return query.Distinct();
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public ICollection<korisnik> GetEventParticipants(dogadaj _event)
        {
            var query = Entities.FirstOrDefault(e => e.ID == _event.ID).korisnik1;
            return query;
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public bool RemoveUserFromEvent(dogadaj _event, korisnik user)
        {
            using(var context = new EventBuddyModel())
            {
                var selectedUser = (from e in context.korisnik select e).FirstOrDefault(e => e.ID == user.ID);
                var selectedEvent = (from e in context.dogadaj select e).FirstOrDefault(e => e.ID == _event.ID);
                selectedEvent.korisnik1.Remove(selectedUser);
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public bool BanUserFromEvent(dogadaj _event, korisnik user)
        {
            using (var context = new EventBuddyModel())
            {
                var selectedUser = (from e in context.korisnik select e).FirstOrDefault(e => e.ID == user.ID);
                var selectedEvent = (from e in context.dogadaj select e).FirstOrDefault(e => e.ID == _event.ID);
                selectedEvent.korisnik1.Remove(selectedUser);
                selectedEvent.korisnik2.Add(selectedUser);
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public bool DismissEvent(dogadaj _event)
        {
            using (var context = new EventBuddyModel())
            {
                var selectedEvent = (from e in context.dogadaj select e).FirstOrDefault(e => e.ID == _event.ID);
                var selectedStatus = (from e in context.status select e).FirstOrDefault(s => s.naziv == "Obustavljen");
                selectedEvent.ID_status = selectedStatus.ID;
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        /// <param name="_event"></param>
        /// <returns></returns>
        public bool DeleteEvent(dogadaj _event)
        {
            using (var context = new EventBuddyModel())
            {
                var selectedEvent = (from e in context.dogadaj select e).FirstOrDefault(e => e.ID == _event.ID);
                if (selectedEvent != null)
                {
                    selectedEvent.korisnik1.Clear();
                    selectedEvent.korisnik2.Clear();
                    context.dogadaj.Remove(selectedEvent);
                }
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="saveChanges"></param>
        /// <returns></returns>
        public int Update(dogadaj entity, bool saveChanges = true)
        {
            using (var context = new EventBuddyModel())
            {
                var selectedEvent = (from e in context.dogadaj select e).FirstOrDefault(e => e.ID == entity.ID);
                if (selectedEvent != null)
                {
                    selectedEvent.datum = entity.datum;
                    selectedEvent.mjesto = entity.mjesto;
                    selectedEvent.naziv = entity.naziv;
                    selectedEvent.opis = entity.opis;
                }
                return saveChanges ? context.SaveChanges() : 0;
            }
        }
    }
}
