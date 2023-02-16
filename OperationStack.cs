namespace Task_Polymorphysm2_UndoOperations
{
    public class OperationStack
    {
        private readonly Stack<Operation> _operations = new ();

        public void AddOperation(Operation operation)
        {
            _operations.Push(operation);
        }

        public bool TryUndoOperation()
        {
            if (_operations.TryPop(out Operation operation) == true)
            {
                operation.Undo();
                return true;
            }

            return false;
        }
    }
}