using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class TypeScheduleController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/TypeSchedule
        public IEnumerable<TypeSchedule> Get()
        {
            return context.TypeSchedules.ToList();
        }

        // GET: api/TypeSchedule/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TypeSchedule
        public int Post([FromBody]TypeSchedule typeSchedule)
        {
            try
            {
                context.TypeSchedules.Add(typeSchedule);
                context.SaveChanges();
                return typeSchedule.idTypeSchedule;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/TypeSchedule/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TypeSchedule/5
        public void Delete(int id)
        {
        }
    }
}
