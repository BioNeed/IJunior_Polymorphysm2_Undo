namespace Task_Polymorphysm2_UndoOperations
{
    public abstract class AccountOperation : Operation
    {
        protected Accounts Accounts;

        public AccountOperation(Accounts accounts)
        {
            Accounts = accounts;
        }
    }
}