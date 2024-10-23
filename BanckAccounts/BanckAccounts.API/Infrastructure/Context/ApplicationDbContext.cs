using BankAccounts.API.Domain;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.API.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
            base(options)
        {

        }
    }
}
