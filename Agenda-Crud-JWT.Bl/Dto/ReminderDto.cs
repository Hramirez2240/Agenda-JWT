using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Crud_JWT.Bl.Dto
{
    public class ReminderDto : BaseDto
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
    }
}
