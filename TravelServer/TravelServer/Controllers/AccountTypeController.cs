using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class AccountTypeController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/AccountType
        public IEnumerable<AccountType> Get()
        {
            return context.AccountTypes.ToList();
        }

        // GET: api/AccountType/5
        public AccountType Get(int id)
        {
            return context.AccountTypes.FirstOrDefault(x => x.idAccountType == id);
        }

        // POST: api/AccountType
        public int Post([FromBody]AccountType accountType)
        {
            try
            {
                context.AccountTypes.Add(accountType);
                context.SaveChanges();
                return accountType.idAccountType;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/AccountType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AccountType/5
        public void Delete(int id)
        {
        }
    }
}
