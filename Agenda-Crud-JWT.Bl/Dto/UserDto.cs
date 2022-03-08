using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Crud_JWT.Bl.Dto
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
