using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Crud_JWT.Services.JWT
{
    public interface IJWTAuthenticationManager
    {
        string Authenticate(string email, string password);
    }
}
