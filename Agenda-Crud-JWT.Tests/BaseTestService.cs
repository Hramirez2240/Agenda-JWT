using System;
using System.Collections.Generic;
using System.Text;
using Agenda_Crud_JWT.Bl.Dto;
using Agenda_Crud_JWT.Bl.Mappings;
using Agenda_Crud_JWT.Model.Context;
using Agenda_Crud_JWT.Model.Entities;
using Agenda_Crud_JWT.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Agenda_Crud_JWT.Tests
{
    public class BaseTestService
    {
        protected readonly UserService _userService;
        protected readonly DbContextOptionsBuilder<ApplicationDbContext> _contextOptions;

        public BaseTestService()
        {

            #region Automapper

            var mapper = new MapperConfiguration(x => x.AddProfile<ApplicationProfile>())
                .CreateMapper();

            #endregion

            #region ApplicationDbContext

            _contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
            _contextOptions.UseInMemoryDatabase("Agenda");

            var dbcontext = new ApplicationDbContext(_contextOptions.Options);

            #endregion

            #region User Service

            _userService = new UserService(dbcontext, mapper);

            #endregion
        }
    }
}
