namespace Task_Polymorphysm2_Undo
{
    public abstract class Operation
    {
        public abstract bool TryRun();

        public abstract void Undo();
    }
}