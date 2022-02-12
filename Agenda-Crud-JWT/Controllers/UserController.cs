using Agenda_Crud_JWT.Bl.Dto;
using Agenda_Crud_JWT.Model.Context;
using Agenda_Crud_JWT.Model.Entities;
using Agenda_Crud_JWT.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agenda_Crud_JWT.Controllers
{
    public class UserController : BaseController<User, UserDto>
    {
        public UserController(IUserService userService) : base(userService)
        {
        }
    }
}
