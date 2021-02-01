using CleanArchitecture.ApplicationLayer.Interface;
using CleanArchitecture.ApplicationLayer.Services;
using CleanArchitecture.DomainLayer.Interface;
using CleanArchitecture.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
namespace CleanArchitecture.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IBookService, BookService>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
