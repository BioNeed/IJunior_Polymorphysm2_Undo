namespace Task_Polymorphysm2_Undo
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