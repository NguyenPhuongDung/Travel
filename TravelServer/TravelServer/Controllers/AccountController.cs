using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class AccountController : ApiController
    {

        DataContext context = new DataContext();
        // GET: api/Account
        public IEnumerable<Account> Get()
        {
            List<Account> accounts = context.Accounts.ToList();
            foreach(Account account in accounts)
            {
                account.AccountType = null;
                
            }
            return accounts;
        }

        // GET: api/Account/5
        public Account Get(int id)
        {
            return context.Accounts.SingleOrDefault(x => x.idAccount == id);
        }

        // POST: api/Account
        public int Post([FromBody]Account account)
        {
            try
            {
                context.Accounts.Add(account);
                context.SaveChanges();
                return account.idAccount;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/Account/5
        public bool Put(int id, [FromBody]Account account)
        {
            try
            {
                Account acc = context.Accounts.FirstOrDefault(x => x.idAccount == id);
                if (acc != null)
                {
                    acc.username = account.username;
                    acc.password = account.password;
                    acc.fullName = account.fullName;
                    acc.phone = account.phone;
                    acc.idAccountType = account.idAccountType;
                    acc.state = account.state;

                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        // DELETE: api/Account/5
        public bool Delete(int id)
        {
            try
            {
                Account account = context.Accounts.FirstOrDefault(x => x.idAccount == id);
                if (account != null)
                {
                    context.Accounts.Remove(account);
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
