using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class LocationController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/Location
        public IEnumerable<Location> Get()
        {
            return context.Locations.ToList();
        }

        // GET: api/Location/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Location
        public int Post([FromBody]Location location)
        {
            try
            {
                context.Locations.Add(location);
                context.SaveChanges();
                return location.idLocation;
            }
            catch
            {
                return -1;
            }
        }
        //khi du lieu goi len k co truong id,
        // PUT: api/Location/5
        public bool Put(int id, [FromBody]Location location)
        {
            try
            {
                Location lct = context.Locations.FirstOrDefault(x => x.idLocation == id);
                if (lct != null)
                {
                    lct.nameLocation = location.nameLocation;
                    lct.address = location.address;
                    lct.contact = location.contact;
                    lct.description = location.description;
                    lct.idTypeLocation = location.idTypeLocation;
                    lct.idMap = location.idMap;
                    lct.idAccount = location.idAccount;
                    location.state = location.state;

                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        // DELETE: api/Location/5
        public bool Delete(int id)
        {
            try
            {
                Location location = context.Locations.FirstOrDefault(x => x.idLocation == id);
                if (location != null)
                {
                    context.Locations.Remove(location);
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
