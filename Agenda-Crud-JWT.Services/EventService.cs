using Agenda_Crud_JWT.Bl.Dto;
using Agenda_Crud_JWT.Model.Context;
using Agenda_Crud_JWT.Model.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Crud_JWT.Services
{
    public interface IEventService : IBaseService<Event, EventDto>
    {

    }

    public class EventService : BaseService<Event, EventDto>, IEventService
    {
        public EventService(IApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override async Task<EventDto> Create(EventDto dto)
        {
            var entity = _mapper.Map<Event>(dto);

            var equalDates = DateService.IsEqualDates(_dbset, entity);

            var compareDates = DateService.IsEarlyDate(entity);

            if (equalDates || compareDates)
            {
                return null;
            }

            var eventName = entity.Name;

            var eventDate = entity.Date;

            _dbset.Add(entity);

            await _context.SaveChangesAsync();

            EmailService.CreateMessage(entity.EmailInvitation, eventName, eventDate);

            return _mapper.Map(entity, dto);
        }

        public override async Task<EventDto> Edit(int id, EventDto dto)
        {
            var entity = await _dbset.FindAsync(id);

            if (entity == null)
            {
                return null;
            }

            if (entity.Completed)
            {
                return null;
            }

            entity = _mapper.Map(dto, entity);

            _dbset.Update(entity);

            await _context.SaveChangesAsync();

            return _mapper.Map(entity, dto);
        }
    }
}
