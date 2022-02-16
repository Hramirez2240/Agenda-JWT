/*using Agenda_Crud_JWT.Model.Context;
using Agenda_Crud_JWT.Model.Entities;
using Agenda_Crud_JWT.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertEvent.Services
{
    public class AlertService
    {
        private readonly IApplicationDbContext _context;
        private readonly EmailService _emailService;

        public AlertService(IApplicationDbContext context, EmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public async Task SendReminder()
        {
            var events = await _context.GetDbSet<Event>()
                .Where(x => x.Date >= DateTime.Now.AddMinutes(10)
                && x.Date <= DateTime.Now.AddMinutes(20))
                //.Include(x => x.Invitations)
                .ToListAsync();

            /*foreach(var event in events)
             * {
             *      var invitations = events.Invitations
             *          .where(x => )
             * }
        }
    }
}

            /*
                public async task RemindInvitation(invitationdto)
             */
