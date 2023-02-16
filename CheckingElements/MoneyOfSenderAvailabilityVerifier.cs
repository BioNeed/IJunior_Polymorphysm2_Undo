namespace Task_Polymorphysm2_UndoOperations
{
    public class MoneyOfSenderAvailabilityVerifier
    {
        public static bool IsEnoughMoney(Account moneySender, double moneyToSend)
        {
            return moneySender.Money >= moneyToSend;
        }
    }
}