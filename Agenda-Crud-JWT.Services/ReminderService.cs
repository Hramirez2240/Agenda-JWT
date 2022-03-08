using Agenda_Crud_JWT.Bl.Dto;
using Agenda_Crud_JWT.Model.Context;
using Agenda_Crud_JWT.Model.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Crud_JWT.Services
{
    public interface IReminderService : IBaseService<Reminder, ReminderDto>
    {
        Task Create(int eventid, int userid);
    }

    public class ReminderService : BaseService<Reminder, ReminderDto>, IReminderService
    {

        public ReminderService(IApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        [Authorize]
        public async Task Create(int eventid, int userid)
        {
            var entity = new Reminder()
            {
                EventId = eventid,
                UserId = userid
            };

            _dbset.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}