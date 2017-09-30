using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class MapController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/Map
        public IEnumerable<Map> Get()
        {
            return context.Maps.ToList();
        }

        // GET: api/Map/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Map
        public int Post([FromBody]Map map)
        {
            try
            {
                context.Maps.Add(map);
                context.SaveChanges();
                return map.idMap;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/Map/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Map/5
        public void Delete(int id)
        {
        }
    }
}
