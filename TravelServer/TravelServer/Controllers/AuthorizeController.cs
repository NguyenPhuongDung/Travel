using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class AuthorizeController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/Authorize
        public IEnumerable<Authorize> Get()
        {
            return context.Authorizes.ToList();
        }

        // GET: api/Authorize/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Authorize
        public int Post([FromBody]Authorize authorize)
        {
            try
            {
                context.Authorizes.Add(authorize);
                context.SaveChanges();
                return authorize.idAuthorize;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/Authorize/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Authorize/5
        public void Delete(int id)
        {
        }
    }
}
