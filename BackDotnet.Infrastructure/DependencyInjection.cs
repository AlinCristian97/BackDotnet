using BackDotnet.Application.Interfaces;
using BackDotnet.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDotnet.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IFruitRepository, FruitRepositoryInMemory>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
