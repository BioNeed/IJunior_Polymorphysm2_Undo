namespace Task_Polymorphysm2_Undo
{
    public class AccountOperationRunner
    {
        private readonly OperationStack _operations;
        private readonly Accounts _accounts;

        public AccountOperationRunner()
        {
            _operations = new OperationStack();

            _accounts = new Accounts(
                new Account(1, 200),
                new Account(4, 4000),
                new Account(10, 500),
                new Account(2, 999));
        }

        public void RunOperation(Type operationType)
        {
            AccountOperation operation =
                (AccountOperation)Activator.CreateInstance(operationType, new object[] { _accounts });

            if (operation is UndoOperation)
            {
                if (_operations.TryUndoOperation() == true)
                {
                    Console.WriteLine("Undo complete!");
                }
                else
                {
                    Console.WriteLine("No operation to undo!");
                }
            }
            else
            {
                if (operation.TryRun() == true)
                {
                    _operations.AddOperation(operation);
                }
            }
        }
    }
}
