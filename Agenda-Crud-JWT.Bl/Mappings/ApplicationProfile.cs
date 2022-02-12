using Agenda_Crud_JWT.Bl.Dto;
using Agenda_Crud_JWT.Model.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Crud_JWT.Bl.Mappings
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Event, EventDto>()
                .ForMember(dest => dest.EmailInvitation, act => act.Ignore())
                .PreserveReferences()
                .ReverseMap();

            CreateMap<User, UserDto>()
                .ReverseMap();
        }
    }
}
