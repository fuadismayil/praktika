//pensiya 500azn, 1- balans goster, 2- balansa deposit, 3- balansdan withdraw, 4- exit
double balance = 500;
bool isTerminated = true;
int pin = 1234;
Console.WriteLine("Please enter 4 digit pin, you have 3 chances left!");
for (int i = 0; i < 3; i++)
{
    bool isPinSuccess = int.TryParse(Console.ReadLine(), out int enteredPin);
    if (enteredPin == pin)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Success!");
        Console.ForegroundColor = ConsoleColor.White;
        isTerminated = false;
        break;
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Incorrect pin, try again! You have {2-i} chances left!");
        Console.ForegroundColor = ConsoleColor.White;
        isTerminated = true;
    }
}
if (isTerminated)
{
    Console.Clear();
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("Access terminated!");
    Console.ForegroundColor = ConsoleColor.White;
    Environment.Exit(0);
}
while (true)
{
    Console.WriteLine("--------------------\nWellcome to CFF ATM\n--------------------");
    Console.WriteLine("1- Show Balance\n2- Deposit\n3- Withdrawal\n4- Exit");
    bool isSuccess = int.TryParse(Console.ReadLine(), out int selectedProcess); switch (selectedProcess)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Your current Balance: " + balance + " Azn");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Enter amount of deposit: ");
            bool amountDeposit = double.TryParse(Console.ReadLine(), out double deposit);
            if (amountDeposit == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter numbers only.");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            if (deposit < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Negative numbers are not allowed!");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            balance += deposit;
            Console.WriteLine($"+{deposit} Azn, Your current balance: " + balance + " Azn");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Enter amount of withdraw: ");
            bool amountWithdraw = double.TryParse(Console.ReadLine(), out double withdraw);
            if (amountWithdraw == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter numbers only.");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            if (withdraw < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Negative numbers are not allowed!");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            if (withdraw > balance)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You don't have enough balance.");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            else
            {
                balance -= withdraw;
                Console.WriteLine($"-{withdraw} Azn, Your current balance: " + balance + " Azn");
                break;
            }
        case 4:
            Console.Clear();
            Console.WriteLine("--------------------\nGoodBye\n--------------------");
            Environment.Exit(0);

            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please select correct process");
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }
}