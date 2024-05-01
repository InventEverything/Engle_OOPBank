namespace Engle_OOPBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo UserInput;
            Bank Account = new Bank(1000);
            MainMenu();
            do
            {
                UserInput = Console.ReadKey();
                if (UserInput.Key == ConsoleKey.D)
                {
                    NextMenu("How much would you like to deposit?\n$");
                    Account.Deposit(decimal.Parse(Console.ReadLine()));
                    ReportBalance(Account.Balance);
                    MainMenu();
                }
                else if(UserInput.Key == ConsoleKey.W)
                {
                    if (Account.Balance == 0m)
                    {
                        NextMenu("Unable to withdraw on 0 balance.");
                        Console.ReadKey();
                    }
                    else
                    {
                        NextMenu("How much would you like to withdraw?\n$");
                        Account.Withdraw(decimal.Parse(Console.ReadLine()));
                    }
                    ReportBalance(Account.Balance);
                    MainMenu();
                }
                else if(UserInput.Key == ConsoleKey.B)
                {
                    ReportBalance(Account.Balance);
                    MainMenu();
                }
                else if (UserInput.Key == ConsoleKey.Q)
                {
                    NextMenu("Good bye!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    MainMenu(UserInput);
                }
            } while (true);

        }
        static void ReportBalance(decimal x)
        {
            Console.Clear();
            Console.WriteLine("Your balance is: " + x.ToString("c")+"\n");
        }
        static void NextMenu(string x)
        {
            Console.Clear();
            Console.Write(x);
        }
        static void MainMenu()
        {
            Console.Write("Deposit (D)\n" +
                "Withdraw (W)\n" +
                "Check Balance (B)\n" +
                "Quit (Q)\n" +
                "Please make your selection: ");
        }
        static void MainMenu(ConsoleKeyInfo x)
        {
            Console.Write("Deposit (D)\n" +
                "Withdraw (W)\n" +
                "Check Balance (B)\n" +
                "Quit (Q)\n" +
                "Please make your selection: "+x.Key);
        }
    }
}
