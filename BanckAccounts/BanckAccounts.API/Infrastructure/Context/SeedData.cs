using BankAccounts.API.Domain;

namespace BankAccounts.API.Infrastructure.Context
{
    public static class SeedDataExtension
    {
        public static void ApplySeedData(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var service = scope.ServiceProvider;
            var loggerFactory = service.GetRequiredService<ILoggerFactory>();

            try
            {
                var context = service.GetRequiredService<ApplicationDbContext>();

                BankAccount[] seedData =  [BankAccount.Create("Raúl Menendez"),
                BankAccount.Create("Yago Medina"),
                BankAccount.Create("Antonio Manuel Miranda"),
                BankAccount.Create("Maria Guadalupe Cardona"),
                BankAccount.Create("Filomena Cabrera"),
                BankAccount.Create("Caridad Díaz")];

                context.Set<BankAccount>().AddRange(seedData);

                context.SaveChanges();

            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ApplicationDbContext>();
                logger.LogError(e.Message);
            }
        }
    }
}
