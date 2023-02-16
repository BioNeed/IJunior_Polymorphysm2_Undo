namespace Task_Polymorphysm2_UndoOperations
{
    public class Account
    {
        public Account(int id, double money = 0)
        {
            Id = id;
            Money = money;
        }

        public int Id { get; private set; }

        public double Money { get; private set; }

        public void ReceiveMoney(double money)
        {
            Money += money;
        }

        public void SendMoney(double money)
        {
            Money -= money;
        }
    }
}