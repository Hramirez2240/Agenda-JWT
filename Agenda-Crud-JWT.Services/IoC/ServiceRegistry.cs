using Agenda_Crud_JWT.Services.JWT;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Crud_JWT.Services.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServiceRegistry(this IServiceCollection services)
        {
            services.AddTransient<IEventService, EventService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IReminderService, ReminderService>();
            services.AddScoped<IJWTAuthenticationManager, JWTAuthenticationManager>();
        }
    }
}
