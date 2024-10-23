using BankAccounts.API.Domain.Repositories;
using BankAccounts.API.Infrastructure.Context;
using BankAccounts.API.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.API.Infrastructure
{
    public static class DependencyInjection
    {
        public static void RegisterInfrastructure(this IServiceCollection services) 
        { 
            services.AddScoped<IBankAccountRepository,BankAccountRepository>();

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseInMemoryDatabase("ExampleDataBase"));

            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            });
        }

    }
}
