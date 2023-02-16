namespace Task_Polymorphysm2_UndoOperations
{
    public class InputValidator
    {
        public static bool TryGetInt(string requestText, out int result)
        {
            Console.Write(requestText);

            if (int.TryParse(Console.ReadLine(), out result) == false)
            {
                return false;
            }

            return true;
        }

        public static bool TryGetDouble(string requestText, out double result)
        {
            Console.Write(requestText);

            if (double.TryParse(Console.ReadLine(), out result) == false)
            {
                return false;
            }

            return true;
        }
    }
}