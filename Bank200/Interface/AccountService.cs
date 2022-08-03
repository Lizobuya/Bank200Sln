namespace Bank200.Interface
{
    public interface AccountService
    {
        
        public void openSavingsAccount(long accountId, long amountToDeposit);
        public void openCurrentAccount(long accountId);
        public void withdraw(long accountId, int amountToWithdraw);
        
        //throws AccountNotFoundException,
       // WithdrawalAmountTooLargeException; 
        public void deposit(long accountId, int amountToDeposit);
       // throws AccountNotFoundException;

    

    }
}
