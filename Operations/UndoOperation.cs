namespace Task_Polymorphysm2_Undo
{
    public class UndoOperation : AccountOperation
    {
        public UndoOperation(Accounts accountsList)
            : base(accountsList)
        {
        }

        public override bool TryRun()
        {
            throw new InvalidOperationException();
        }

        public override void Undo()
        {
            throw new InvalidOperationException();
        }
    }
}
