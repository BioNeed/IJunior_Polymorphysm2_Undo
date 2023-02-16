namespace Task_Polymorphysm2_UndoOperations
{
    public class Accounts
    {
        private readonly List<Account> _accounts;

        public Accounts(params Account[] accounts)
        {
            _accounts = accounts.ToList();
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accounts;
        }

        public bool TryGetAccountByID(int accountID, out Account? result)
        {
            foreach (Account account in _accounts)
            {
                if (account.Id == accountID)
                {
                    result = account;
                    return true;
                }
            }

            result = null;
            return false;
        }

        public void AddAccount(Account addingAccount)
        {
            _accounts.Add(addingAccount);
        }

        public void RemoveAccount(Account accountToDelete)
        {
            _accounts.Remove(accountToDelete);
        }
    }
}