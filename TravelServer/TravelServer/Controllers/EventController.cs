using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class EventController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/Event
        public IEnumerable<Event> Get()
        {
            return context.Events.ToList();
        }

        // GET: api/Event/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Event
        public int Post([FromBody]Event events)
        {
            try
            {
                context.Events.Add(events);
                context.SaveChanges();
                return events.idEvent;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/Event/5
        public bool Put(int id, [FromBody]Event events)
        {
            try
            {
                Event Events = context.Events.FirstOrDefault(x => x.idEvent == id);
                if (Events != null)
                {
                    Events.nameEvent = events.nameEvent;
                    Events.idLocation = events.idLocation;
                    Events.timeStartEvent = events.timeStartEvent;
                    Events.timeFinishEvent = events.timeFinishEvent;
                    Events.description = events.description;
                    Events.idAccount = events.idAccount;
                    Events.state = events.state;
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        // DELETE: api/Event/5
        public bool Delete(int id)
        {
            try
            {
                Event Events = context.Events.FirstOrDefault(x => x.idEvent == id);
                if (Events != null)
                {
                    context.Events.Remove(Events);
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
