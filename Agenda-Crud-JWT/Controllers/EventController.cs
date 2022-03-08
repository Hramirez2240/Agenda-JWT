using Agenda_Crud_JWT.Bl.Dto;
using Agenda_Crud_JWT.Model.Entities;
using Agenda_Crud_JWT.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Agenda_Crud_JWT.Controllers
{
    [Authorize]
    public class EventController : BaseController<Event, EventDto>
    {

        public EventController(IEventService eventService) : base(eventService)
        {
            
        }
    }
}