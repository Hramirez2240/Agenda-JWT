using Agenda_Crud_JWT.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda_Crud_JWT.Services
{
    public class DateService
    {
        public static bool IsEqualDates(DbSet<Event> _dbset, Event entity)
        {
            var items = _dbset.Select(x => x.Date);

            foreach (var dates in items)
            {
                if (dates == entity.Date)
                {
                    return true;
                }
                else { continue; }
            }

            return false;
        }

        public static bool IsEarlyDate(Event entity)
        {
            var dateRest = DateTime.Compare(entity.Date, DateTime.Now);
            if (dateRest < 0)
            {
                return true;
            }

            return false;
        }
    }
}
