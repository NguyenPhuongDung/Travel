using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class TypeImageController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/TypeImage
        public IEnumerable<TypeImage> Get()
        {
            return context.TypeImages.ToList();
        }

        // GET: api/TypeImage/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TypeImage
        public int Post([FromBody]TypeImage typeImage)
        {
            try
            {
                context.TypeImages.Add(typeImage);
                context.SaveChanges();
                return typeImage.idTypeImage;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/TypeImage/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TypeImage/5
        public void Delete(int id)
        {
        }
    }
}
