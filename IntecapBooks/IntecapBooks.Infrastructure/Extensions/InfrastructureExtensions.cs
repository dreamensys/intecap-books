using IntecapBooks.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntecapBooks.Infrastructure.Extensions
{
    public static class InfrastructureExtensions
    {

        public static IServiceCollection AddDatabaseProvider(this IServiceCollection services) 
        {
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IntecapBooks;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            return services;
        }
    }
}
