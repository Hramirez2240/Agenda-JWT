using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Crud_JWT.Model.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}
