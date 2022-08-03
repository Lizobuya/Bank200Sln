using Bank200.Models;
using Microsoft.EntityFrameworkCore;

namespace Bank200.Data
{
    public class BankingContext
              : DbContext
    {



        public BankingContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

    }
}
