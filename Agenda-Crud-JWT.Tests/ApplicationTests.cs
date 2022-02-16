using Agenda_Crud_JWT.Bl.Dto;
using Agenda_Crud_JWT.Model.Context;
using Agenda_Crud_JWT.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Agenda_Crud_JWT.Tests
{
    public class ApplicationTests : BaseTestService
    {
        [Fact]
        public async Task ShouldGetUsers()
        {
            //Act
            var result = await _userService.Get();

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldGetUserById()
        {
            //Arrange
            int id = 1;

            //Act
            var result = await _userService.Get(id);

            //Assert
            Assert.Equal(id, result.Id);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldCreateUser()
        {
            //Arrange
            var user = new UserDto()
            {
                Id = 1,
                Name = "Hector",
                LastName = "Ramirez",
                Email = "hramirez2298@gmail.com",
                Password = "prueba1234"
            };

            //Act
            var result = await _userService.Create(user);

            //Assert
            Assert.Same(user, result);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldUpdateUser()
        { 
            //Arrange
            var user = new UserDto()
            {
                Id = 1,
                Name = "Luis",
                LastName = "Ramirez",
                Email = "hramirez2298@gmail.com",
                Password = "prueba1234"
            };

            //Act
            var result = await _userService.Edit(user.Id, user);

            //Assert
            Assert.IsType<UserDto>(result);
            Assert.Same(user, result);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldDeleteUser()
        {
            //Arrange
            int id = 2;

            //Act
            var result = await _userService.Delete(id);

            //Assert
            Assert.NotNull(result);
        }
        
    }
}
