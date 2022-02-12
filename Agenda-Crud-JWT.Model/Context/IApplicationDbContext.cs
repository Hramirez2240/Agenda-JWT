using Agenda_Crud_JWT.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Agenda_Crud_JWT.Model.Context
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<T> GetDbSet<T>() where T : class, IBaseEntity;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        DatabaseFacade Database { get; }
    }
}
