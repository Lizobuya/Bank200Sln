using Bank200.Models;
namespace Bank200.Data
{
    public class SystemDB
    {
        private readonly BankingContext _context;

        public SystemDB(BankingContext context)
        {
            _context = context;
        }

        public void Run()
        {
            if (!_context.TransactionTypes.Any())
            {

                var transactionType = new TransactionType();
                transactionType.Description = "Deposit Funds";
                _context.TransactionTypes.Add(transactionType);

                transactionType = new TransactionType();
                transactionType.Description = "Withdraw Funds";
                _context.TransactionTypes.Add(transactionType);

                _context.SaveChanges();
            }

            if (!_context.AccountTypes.Any())
            {
                var accountType = new AccountType();
                accountType.Description = "Savings";
                _context.AccountTypes.Add(accountType);

                accountType = new AccountType();
                accountType.Description = "Current";
                _context.AccountTypes.Add(accountType);

                _context.SaveChanges();
            }

            
               
        }

    }
}
