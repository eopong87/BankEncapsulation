namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);
            account.Deposit(843);


            Console.WriteLine($"thank you! your balance is {account.GetBalance()}");

        }
    }
}
