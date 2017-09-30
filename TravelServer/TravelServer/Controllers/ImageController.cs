using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class ImageController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/Image
        public IEnumerable<Image> Get()
        {
            return context.Images.ToList();
        }

        // GET: api/Image/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Image
        public int Post([FromBody]Image image)
        {
            try
            {
                context.Images.Add(image);
                context.SaveChanges();
                return image.idImage;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/Image/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Image/5
        public void Delete(int id)
        {
        }
    }
}
