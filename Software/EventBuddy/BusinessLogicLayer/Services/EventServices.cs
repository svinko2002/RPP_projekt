using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using EntitiesLayer.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class EventServices
    {
        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public List<dogadaj> GetAllEvents()
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                List<dogadaj> eventList = repo.GetAll().ToList();
                return eventList;
            }
        }

        /// <summary>
        /// <author>Sebastijan Vinko</author>
        /// </summary>
        public int hideEvent(dogadaj selectedEvent)
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.hideEvent(selectedEvent);
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public List<string> GetLocations()
        {
            using(var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.GetLocations().ToList();
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public List<korisnik> GetEventParticipants(dogadaj _event)
        {
            using(var repo = new EventRepository(new EventBuddyModel()))
            {
                var participants = repo.GetEventParticipants(_event).ToList();
                return participants;
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public bool RemoveUserFromEvent(dogadaj _event, korisnik user)
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.RemoveUserFromEvent(_event, user);
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public bool BanUserFromEvent(dogadaj _event, korisnik user)
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.BanUserFromEvent(_event, user);
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        public bool DismissEvent(dogadaj _event)
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.DismissEvent(_event);
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        /// <param name="_event"></param>
        /// <returns></returns>
        public bool DeleteEvent(dogadaj _event)
        {
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.DeleteEvent(_event);
            }
        }

        /// <summary>
        /// <author>Dominik Josipović</author>
        /// </summary>
        /// <param name="_event"></param>
        /// <returns></returns>
        public bool UpdateEvent(dogadaj _event)
        {
            if (_event.naziv.Trim() == "")
                throw new EventException("Ime ne smije biti prazno!");
            if (_event.naziv.Trim().Length > 25)
                throw new EventException("Ime ne smije biti dulje od 25 znakova!");
            if (_event.opis.Trim() == "")
                throw new EventException("Opis ne smije biti prazan!");
            if (_event.mjesto.Trim() == "")
                throw new EventException("Mjesto ne smije biti prazno!");
            if (_event.mjesto.Trim().Length > 30)
                throw new EventException("Mjesto ne smije biti dulje od 30 znakova!");
            using (var repo = new EventRepository(new EventBuddyModel()))
            {
                return repo.Update(_event) > 0;
            }
        }
    }
}
