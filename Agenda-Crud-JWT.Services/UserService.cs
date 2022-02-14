using Agenda_Crud_JWT.Bl.Dto;
using Agenda_Crud_JWT.Model.Context;
using Agenda_Crud_JWT.Model.Entities;
using Agenda_Crud_JWT.Services.JWT;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Crud_JWT.Services
{
    public interface IUserService : IBaseService<User, UserDto>
    {

    }

    public class UserService : BaseService<User, UserDto>, IUserService
    {
        //public static List<string> toAddress = new List<string> {};

        public UserService(IApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            
        }

    }
}
