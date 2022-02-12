using Agenda_Crud_JWT.Model.Context;
using Agenda_Crud_JWT.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Crud_JWT.Services
{
    public class UserDataService
    {
        public static User GetUserData(IApplicationDbContext _context, int id)
        {
            return _context.GetDbSet<User>().Find(id);
        }
    }
}
