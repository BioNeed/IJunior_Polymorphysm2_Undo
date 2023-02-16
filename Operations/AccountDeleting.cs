namespace Task_Polymorphysm2_Undo
{
    public class AccountDeleting : AccountOperation
    {
        private Account? _deletedAccount;

        public AccountDeleting(Accounts accountsList)
            : base(accountsList)
        {
        }

        public override bool TryRun()
        {
            if (InputValidator.TryGetInt("Enter id of account to delete (int): ", out int delAccountId) == false)
            {
                Console.WriteLine("You should enter int value. Try again...");
                return false;
            }

            if (TryDeleteAccount(delAccountId) == false)
            {
                Console.WriteLine("Account with id " + delAccountId + " does not exist. Try again...");
                return false;
            }

            Console.WriteLine("Account deleted!");
            return true;
        }

        public override void Undo()
        {
            Accounts.AddAccount(_deletedAccount);
        }

        private bool TryDeleteAccount(int id)
        {
            if (Accounts.TryGetAccountByID(id, out _deletedAccount) == true)
            {
                Accounts.RemoveAccount(_deletedAccount);
                return true;
            }

            return false;
        }
    }
}