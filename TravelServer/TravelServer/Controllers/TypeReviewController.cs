using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class TypeReviewController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/TypeReview
        public IEnumerable<TypeReview> Get()
        {
            return context.TypeReviews.ToList();
        }

        // GET: api/TypeReview/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TypeReview
        public int Post([FromBody]TypeReview typeReview)
        {
            try
            {
                context.TypeReviews.Add(typeReview);
                context.SaveChanges();
                return typeReview.idTypeReview;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/TypeReview/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TypeReview/5
        public void Delete(int id)
        {
        }
    }
}
