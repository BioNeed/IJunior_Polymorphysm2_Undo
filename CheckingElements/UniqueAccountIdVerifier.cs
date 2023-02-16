namespace Task_Polymorphysm2_UndoOperations
{
    public class UniqueAccountIdVerifier
    {
        public static bool IsIdUnique(int id, Accounts accountsList)
        {
            IEnumerable<Account> accounts = accountsList.GetAccounts();

            foreach (Account account in accounts)
            {
                if (id == account.Id)
                {
                    return false;
                }
            }

            return true;
        }
    }
}