double GetNumber()
{
    double num;

    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out num))
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
/*string FindBig(double firstNumber, double secondNumber)
{
    return firstNumber > secondNumber ? $"{firstNumber} boyukdur {secondNumber} den" : secondNumber > firstNumber ? $"{secondNumber} boyukdur {firstNumber} den" : "ededler beraberdir";
}*/

//////2
/////Console.WriteLine(Remainder(GetNumber()));
/*static string Remainder(double num)
{
    return num % 2 == 0 ? $"{num} 2 ye qaliqsiz bolunur" : $"{num} 2 ye qaliqsiz bolunmur";
}*/

//////3
//Console.WriteLine(BigSmall(GetNumber()));
/*string BigSmall(double insertedNum)
{
    return insertedNum >= 100 ? "boyuk" : "kicik";
}*/

//////4
//Console.WriteLine(AgeChecker(GetNumber()));
/*string AgeChecker(double age)
{
    return age >= 0 ? "adult" : "child";
}
*/

//////5
//Console.WriteLine(CheckNumberSign(GetNumber()));
/*string CheckNumberSign(double num)
{
    return num > 0 ? "positive" : num == 0 ? "zero" : "negative" ;
}*/

//////6
//Console.WriteLine("Import the number of the week whose name you want to learn:");
//Console.WriteLine(WeekDay(GetNumber()));
/*string WeekDay(double weekday)
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
*/

//////7
//Console.WriteLine(GetCubic(GetNumber()));
/* double GetCubic(double num)
{
    return num * num * num;
}*/

//////8
//Console.WriteLine(FindMonthDay(GetNumber()));
/*string FindMonthDay(double day)
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
}*/