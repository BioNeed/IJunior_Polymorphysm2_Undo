namespace Task_Polymorphysm2_Undo
{
    public class Program
    {
        public static void Main()
        {
            var operationRunner = new AccountOperationRunner();

            while (true)
            {
                string commandString = Console.ReadLine();
                if (OperationTypes.TryGetOperationType(commandString, out Type operationType) == true)
                {
                    operationRunner.RunOperation(operationType);
                }
                else
                {
                    Console.WriteLine("Unknown operation! You should enter existing command...");
                }
            }
        }
    }
}