using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Crud_JWT.Model.Entities
{
    public class Reminder : BaseEntity
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
    }
}
