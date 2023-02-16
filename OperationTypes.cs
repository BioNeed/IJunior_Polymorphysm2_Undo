namespace Task_Polymorphysm2_UndoOperations
{
    public class OperationTypes
    {
        private static readonly Dictionary<string, Type?> _operationsDictionary = new ()
        {
            { "addAcc", typeof(AccountAdding) },
            { "delAcc", typeof(AccountDeleting) },
            { "transmit", typeof(MoneyTransfer) },
            { "undo", typeof(UndoOperation) },
        };

        public static bool TryGetOperationType(string commandString, out Type operationType)
        {
            bool containsOperation = _operationsDictionary.TryGetValue(commandString, out operationType);

            return containsOperation;
        }
    }
}