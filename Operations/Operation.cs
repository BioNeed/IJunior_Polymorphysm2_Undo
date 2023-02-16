namespace Task_Polymorphysm2_UndoOperations
{
    public abstract class Operation
    {
        public abstract bool TryRun();

        public abstract void Undo();
    }
}