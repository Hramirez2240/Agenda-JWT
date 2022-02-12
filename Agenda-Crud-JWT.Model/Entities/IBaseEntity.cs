using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Crud_JWT.Model.Entities
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
