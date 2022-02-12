using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Agenda_Crud_JWT.Model.Entities
{
    public class Event : BaseEntity
    {
        public DateTime Date { get; set; }
        public bool Completed { get; set; } = false;

        [NotMapped]
        public List<string> EmailInvitation { get; set; }
    }
}
