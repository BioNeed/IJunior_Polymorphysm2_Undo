namespace Task_Polymorphysm2_UndoOperations
{
    public class AccountAdding : AccountOperation
    {
        private Account _addedAccount;
        private int _newAccountId;
        private double _newAccountMoney;

        public AccountAdding(Accounts accountsList)
            : base(accountsList)
        {
        }

        public override bool TryRun()
        {
            if (TryInitAddingData() == false)
            {
                return false;
            }

            if (TryAddAccount(_newAccountId, _newAccountMoney) == false)
            {
                Console.WriteLine("Account with id " + _newAccountId + " already exists. Try again...");
                return false;
            }

            Console.WriteLine("Account added!");
            return true;
        }

        public override void Undo()
        {
            Accounts.RemoveAccount(_addedAccount);
        }

        private bool TryInitAddingData()
        {
            if (InputValidator.TryGetInt("Enter id of new account (int): ", out _newAccountId) == false)
            {
                Console.WriteLine("You should enter int value. Try again...");
                return false;
            }

            if (InputValidator.TryGetDouble("Enter money of new account (double): ", out _newAccountMoney) == false)
            {
                Console.WriteLine("You should enter double value. Try again...");
                return false;
            }

            return true;
        }

        private bool TryAddAccount(int id, double money)
        {
            if (UniqueAccountIdVerifier.IsIdUnique(id, Accounts) == true)
            {
                _addedAccount = new Account(id, money);
                Accounts.AddAccount(_addedAccount);
                return true;
            }

            return false;
        }
    }
}
