using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class TypeLocationController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/TypeLocation
        public IEnumerable<TypeLocation> Get()
        {
            return context.TypeLocations.ToList();
        }

        // GET: api/TypeLocation/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TypeLocation
        public int Post([FromBody]TypeLocation typeLocation)
        {
            try
            {
                context.TypeLocations.Add(typeLocation);
                context.SaveChanges();
                return typeLocation.idTypeLocation;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/TypeLocation/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TypeLocation/5
        public void Delete(int id)
        {
        }
    }
}
