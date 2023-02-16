namespace Task_Polymorphysm2_UndoOperations
{
    public class MoneyTransfer : AccountOperation
    {
        private Account? _moneySender;
        private Account? _moneyReceiver;
        private int _moneySenderId;
        private int _moneyReceiverId;
        private double _moneyToSend;

        public MoneyTransfer(Accounts accountsList)
            : base(accountsList)
        {
        }

        public override bool TryRun()
        {
            if (TryInputTransferData() == false)
            {
                return false;
            }

            if (TryFindAccountsById() == false)
            {
                return false;
            }

            if (TryTransmitMoney(_moneySender, _moneyReceiver, _moneyToSend) == false)
            {
                Console.WriteLine("Sender doesn't have this amount of money. Try again...");
                return false;
            }

            Console.WriteLine("Money has been sent!");
            return true;
        }

        public override void Undo()
        {
            _moneyReceiver?.SendMoney(_moneyToSend);
            _moneySender?.ReceiveMoney(_moneyToSend);
        }

        private bool TryInputTransferData()
        {
            if (InputValidator.TryGetInt("Enter id of money sender's account (int): ", out _moneySenderId) == false)
            {
                Console.WriteLine("You should enter int value. Try again...");
                return false;
            }

            if (InputValidator.TryGetInt("Enter id of money sender's account (int): ", out _moneyReceiverId) == false)
            {
                Console.WriteLine("You should enter int value. Try again...");
                return false;
            }

            if (InputValidator.TryGetDouble("Enter money to send (double): ", out _moneyToSend) == false)
            {
                Console.WriteLine("You should enter double value. Try again...");
                return false;
            }

            return true;
        }

        private bool TryFindAccountsById()
        {
            if (Accounts.TryGetAccountByID(_moneySenderId, out _moneySender) == false)
            {
                Console.WriteLine("No account with entered id. Try again...");
                return false;
            }

            if (Accounts.TryGetAccountByID(_moneyReceiverId, out _moneyReceiver) == false)
            {
                Console.WriteLine("No account with entered id. Try again...");
                return false;
            }

            return true;
        }

        private bool TryTransmitMoney(Account moneySender, Account moneyReceiver, double moneyToSend)
        {
            if (MoneyOfSenderAvailabilityVerifier.IsEnoughMoney(moneySender, moneyToSend))
            {
                moneySender?.SendMoney(moneyToSend);
                moneyReceiver?.ReceiveMoney(moneyToSend);
                return true;
            }

            return false;
        }
    }
}