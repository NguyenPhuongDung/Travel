using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class ReviewController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/Review
        public IEnumerable<Review> Get()
        {
            return context.Reviews.ToList();
        }

        // GET: api/Review/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Review
        public int Post([FromBody]Review review)
        {
            try
            {
                context.Reviews.Add(review);
                context.SaveChanges();
                return review.idReview;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/Review/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Review/5
        public void Delete(int id)
        {
        }
    }
}
