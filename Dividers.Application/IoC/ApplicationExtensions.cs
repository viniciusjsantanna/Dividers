using Dividers.Application.DTO;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dividers.Application.IoC
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection RegisterApp(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ApplicationExtensions).Assembly);
            services.AddTransient<Response>();
            return services;
        }
    }
}
