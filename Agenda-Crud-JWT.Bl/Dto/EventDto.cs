using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Agenda_Crud_JWT.Bl.Dto
{
    public class EventDto : BaseDto
    {
        public DateTime Date { get; set; }
        public bool Completed { get; set; }

        [NotMapped]
        public List<string> EmailInvitation { get; set; }
    }
}
