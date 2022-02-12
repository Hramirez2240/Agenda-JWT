using Agenda_Crud_JWT.Bl.Dto;
using Agenda_Crud_JWT.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Crud_JWT.Services
{
    public interface IBaseService<T, TDto> where T : IBaseEntity where TDto : BaseDto
    {
        Task<List<T>> Get();
        public Task<TDto> Get(int id);

        public Task<TDto> Create(TDto dto);

        public Task<TDto> Edit(int id, TDto dto);

        public Task<IActionResult> Delete(int id);
    }
}
