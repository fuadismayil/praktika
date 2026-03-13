using System.Diagnostics.CodeAnalysis;

double GetNumber()
{
    double num;

    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out num))
        {
            return num;
        }
        else
        {
            Console.WriteLine("Zehmet olmasa eded daxil edin!");
        }
    }
}
int GetIntNumber()
{
    int num;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out num))
        {
            Console.Clear();
            return num;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Zehmet olmasa eded daxil edin!");
        }
    }
}

//////1 iki ededin boyuyunu tapan alqoritim, ededler console readline den gelecek
//Console.WriteLine("boyuk olan ededi tapmaq ucun birinci ve ikinci ededleri daxil edin:");
//Console.WriteLine(FindBig(GetNumber(), GetNumber()));
string FindBig(double firstNumber, double secondNumber)
{
    return firstNumber > secondNumber ? $"{firstNumber} boyukdur {secondNumber} den" : secondNumber > firstNumber ? $"{secondNumber} boyukdur {firstNumber} den" : "ededler beraberdir";
}

//////2
/////Console.WriteLine(Remainder(GetNumber()));
static string Remainder(double num)
{
    return num % 2 == 0 ? $"{num} 2 ye qaliqsiz bolunur" : $"{num} 2 ye qaliqsiz bolunmur";
}

//////3
//Console.WriteLine(BigSmall(GetNumber()));
string BigSmall(double insertedNum)
{
    return insertedNum >= 100 ? "boyuk" : "kicik";
}

//////4
//Console.WriteLine(AgeChecker(GetNumber()));
string AgeChecker(double age)
{
    return age >= 0 ? "adult" : "child";
}

//////5
//Console.WriteLine(CheckNumberSign(GetNumber()));
string CheckNumberSign(double num)
{
    return num > 0 ? "positive" : num == 0 ? "zero" : "negative";
}

//////6
//Console.WriteLine("Import the number of the week whose name you want to learn:");
//Console.WriteLine(WeekDay(GetNumber()));
string WeekDay(double weekday)
{
    switch (weekday)
    {
        case 1:
            return "Monday";
        case 2:
            return "Tuesday";
        case 3:
            return "Wednesday";
        case 4:
            return "Thrusday";
        case 5:
            return "Friday";
        case 6:
            return "Saturday";
        case 7:
            return "Sunday";
        default:
            return "Wrong week day number imported";
    }
}

//////7
//Console.WriteLine(GetCubic(GetNumber()));
double GetCubic(double num)
{
    return num * num * num;
}

//////8
//Console.WriteLine(FindMonthDay(GetNumber()));
string FindMonthDay(double day)
{
    switch (day)
    {
        case 1:
            return "Yanvar: 31 gun";
        case 2:
            return "Fevral: 28-29 gun";
        case 3:
            return "Mart: 31 gun";
        case 4:
            return "Aprel: 30 gun";
        case 5:
            return "May: 31 gun";
        case 6:
            return "Iyun: 30 gun";
        case 7:
            return "Iyul: 31 gun";
        case 8:
            return "Avqust: 31 gun";
        case 9:
            return "Sentyabr: 30 gun";
        case 10:
            return "Oktyabr: 31 gun";
        case 11:
            return "Noyabr: 30 gun";
        case 12:
            return "Dekabr: 31 gun";
        default:
            return "Bele bir ay yoxdur!";
    }
}

//14
void GetDivideThree(params int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 3 == 0) Console.WriteLine(nums[i]);
    }
}
//GetDivideThree(20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30);

//15
void GetMinMaxAvg(params int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
    }
    Console.WriteLine(nums.Min());
    Console.WriteLine(nums.Max());
    Console.WriteLine($"average: {sum / nums.Length}");
}
//GetMinMaxAvg(20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30);

//16
string CheckPrime(int num)
{
    int divideCount = 0;

    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            divideCount++;
        }
    }

    if (num == 1)
        return "1 is not prime or composite";

    return divideCount == 2 ? "prime" : "not prime";
}
//while (true) { Console.WriteLine(CheckPrime(GetIntNumber())); }

//17
void GetDivideSix(params int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 6 == 0) Console.WriteLine(nums[i]);
    }
}
//GetDivideSix(23, 60, 12, 43, 56, 100, 23, 43, 21, 36, 72);

//18
static double SumTwoNums(double num1, double num2)
{
    return num1 + num2;
}
static double SubtractTwoNums(double num1, double num2)
{
    return num1 - num2;
}
static double MultiplyTwoNums(double num1, double num2)
{
    return num1 * num2;
}
static double DivideTwoNums(double num1, double num2)
{
    return num1 / num2;
}
static double GetRemainderTwoNums(double num1, double num2)
{
    return num1 % num2;
}
static double RaiseToPower(double num1, double num2)
{
    double a = num1;
    for (double i = 1; i < num2; i++) num1 *= a;
    return num1;
}
void Calculator()
{
    while (true)
    {
        Console.WriteLine("\nSelect operation (+, -, *, /, %, ^) or q to quit:");
        char formula = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (formula == 'q')
            break;
        switch (formula)
        {
            case '+':
                Console.WriteLine("Addition selected. enter two numbers");
                Console.WriteLine("Answer: " + SumTwoNums(GetNumber(), GetNumber()));
                break;
            case '-':
                Console.WriteLine("Subtraction selected. enter two numbers");
                Console.WriteLine("Answer: " + SubtractTwoNums(GetNumber(), GetNumber()));
                break;
            case '*':
                Console.WriteLine("Multiplication selected. enter two numbers");
                Console.WriteLine("Answer: " + MultiplyTwoNums(GetNumber(), GetNumber()));
                break;
            case '/':
                Console.WriteLine("Division selected. enter two numbers");
                double num1 = GetNumber();
                double num2 = GetNumber();
                if (num2 == 0)
                {
                    Console.WriteLine("You cannot divide by zero.");
                    break;
                }
                Console.WriteLine("Answer: " + DivideTwoNums(num1, num2));
                break;
            case '%':
                Console.WriteLine("Remainder selected.First enter");
                Console.WriteLine("Answer: " + GetRemainderTwoNums(GetNumber(), GetNumber()));
                break;
            case '^':
                Console.WriteLine("Power selected. First enter number then power.");
                Console.WriteLine("Answer: " + RaiseToPower(GetNumber(), GetNumber()));
                break;
            default:
                Console.WriteLine("Invalid operation. Try again.");
                break;
        }
    }
}
//Calculator();

//19
static void Discount(params double[] prices)
{
    for (int i = 0; i < prices.Length; i++)
    {
        Console.WriteLine(prices[i]*.8);
    }
}
//Discount(100.0, 1300.50, 259.99, 430.30, 160.99, 320.0);

//21
static void FindTriangle(double num1, double num2, double num3)
{
    double a = num1;
    double b = num2;
    double c = num3;
    if (a > b) 
    { 
        double t = a; 
        a = b; 
        b = t; 
    }
    if (a > c) 
    { 
        double t = a; 
        a = c; 
        c = t; 
    }
    if (b > c) 
    { 
        double t = b;
        b = c;
        c = t; 
    }
    if (a == b && b == c)
        Console.WriteLine("beraberterefli ucbucaq");
    else if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
        Console.WriteLine("beraberyanli ucbucaq");
    else if (c * c == (a * a) + (b * b))
        Console.WriteLine("duzbucaqli ucbucaq");
    else
        Console.WriteLine("muxtelifterefli ucbucaq");
}
//FindTriangle(GetNumber(), GetNumber(), GetNumber());


//31
//int a = 10;
//int b = 15;
void ChangeValues(ref int num1, ref int num2)
{
    int a = num1;
    num1 = num2;
    num2 = a;
}
//ChangeValues(ref a, ref b);
//Console.WriteLine($"{a} {b}");


//32
//int eded = 5;
void Add10(ref int num)
{
    num += 10;
}
//Add10(ref eded);
//Console.WriteLine(eded);


//33
void DivideMethod(int num1, int num2, out int qaliq, out int result)
{
    result = num1 / num2;
    qaliq = num1 % num2;
}
//int a;
//int b;
//DivideMethod(5, 3, out a, out b);
//Console.WriteLine("Result: " + b);
//Console.WriteLine("Qalıq: " + a);


//34
void FindMinMax(int num1, int num2, int num3, out int min, out int max)
{
    min = num1;
    max = num1;
    if (num2 < min)
        min = num2;
    if (num3 < min)
        min = num3;
    if (num2 > max)
        max = num2;
    if (num3 > max)
        max = num3;
}
//int a;
//int b;
//FindMinMax(5, 3,6, out a, out b);
//Console.WriteLine($"{a} {b}");


//35
//int a = 85;
void IncreaseScore(ref int score)
{
    if (score <91)
        score += (91-score);
}
//IncreaseScore(ref a);
//Console.WriteLine(a);


//36
string maturity;
void CheckMaturity(string name, int age, out string result)
{
    if(age>=18)
        result= $"{name} is an adult.";
    else
        result = $"{name} is a minor.";
}
//CheckMaturity("Fuad", 19,out maturity);
//Console.WriteLine(maturity);


//37
int[] prices = { 100, 200, 300, 400, 500 };
void DiscountFourty(ref int[] prices)
{
    for (int i = 0; i < prices.Length; i++)
    {
        prices[i] = (int)(prices[i] * 0.6);
    }
}
//DiscountFourty(ref prices);
//for (int i = 0; i < prices.Length; i++)
//{
//    Console.WriteLine(prices[i]);
//}


//38
//string Name()
//{
//    while(true)
//    {
//        string name = Console.ReadLine();
//        if (name == null)
//        {
//            Console.ForegroundColor= ConsoleColor.Red;
//            Console.WriteLine("Please enter your name!");
//            Console.ForegroundColor = ConsoleColor.White;
//        }else if ()
//    }
//}
void RegisterUser(string name, string surname, int age, string email, string password, string username)
{
    DateTime now= DateTime.Now;
    Console.WriteLine($"Name: {name}\nSurname: {surname}\nAge: {age}\nEmail: {email}\nPassword: {password}\nUsername: {username+now.ToString("ddMMyyyyHHmmss")}");
}
//RegisterUser("Fuad", "ismayil", 19, "example@gmail.com", "Fuad2006", "fuad063");