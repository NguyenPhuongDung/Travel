using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelServer.Models;

namespace TravelServer.Controllers
{
    public class ScheduleController : ApiController
    {
        DataContext context = new DataContext();
        // GET: api/Schedule
        public IEnumerable<Schedule> Get()
        {
            return context.Schedules.ToList();
        }

        // GET: api/Schedule/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Schedule
        public int Post([FromBody]Schedule schedule)
        {
            try
            {
                context.Schedules.Add(schedule);
                context.SaveChanges();
                return schedule.idSchedule;
            }
            catch
            {
                return -1;
            }
        }

        // PUT: api/Schedule/5
        public bool Put(int id, [FromBody]Schedule schedule)
        {
            try
            {
                Schedule scd = context.Schedules.FirstOrDefault(x => x.idSchedule == id);
                if (scd != null)
                {
                    scd.nameSchedule = schedule.nameSchedule;
                    scd.timeStartEvent = schedule.timeStartEvent;
                    scd.timeFinishEvent = schedule.timeFinishEvent;
                    scd.description = schedule.description;
                    scd.cost = schedule.cost;
                    scd.idTypeSchedule = schedule.idTypeSchedule;
                    scd.idAccount = schedule.idAccount;
                    scd.state = schedule.state;
              

                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        // DELETE: api/Schedule/5
        public bool Delete(int id)
        {
            try
            {
                Schedule schedule = context.Schedules.FirstOrDefault(x => x.idSchedule == id);
                if (schedule != null)
                {
                    context.Schedules.Remove(schedule);
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
