// 25
//Console.WriteLine("1le 100 arasinda eded daxil et");
//bool input = double.TryParse(Console.ReadLine(), out double inputNumber);
//if(inputNumber>0 && inputNumber < 101)
//{
//    Console.WriteLine($"Daxil etdiyiniz ededin kubu: {Math.Pow(inputNumber,3)}");
//}

//26
//Console.WriteLine("Adinizi daxil edin:");
//string name=Console.ReadLine();
//Console.WriteLine("Soyadinizi daxil edin:");
//string surname=Console.ReadLine();
//string fullName=name+' '+surname;
//Console.WriteLine($"Tam ad: {fullName}");

//27
//Console.WriteLine("Soz daxil edin:");
//string soz=Console.ReadLine();
//Console.WriteLine($"{soz} - {soz.Length} herf");

//28
//string[] sual1 = ["ALMA", "Bu bir meyvedir. 3 cehd sansin var!"];
//string[] sual2 = ["KITAB", "Bu tehsile aid bir esyadir. 3 cehd sansin var!"];
//string[] sual3 = ["MONITOR", "Bu komputerin esas hisselerinden biridir. 3 cehd sansin var!"];
//string correct = "Duz tapdiniz!!!";
//string notCorrect = "Yanlis!!! qalan cehd sansiniz: ";
//string lose = "Meqlub oldunuz, bextinizi bir daha sinayin!";
//bool isTrue = false;
//Random rand = new Random();
//while (true)
//{
//    int randomNumber = rand.Next(1, 4);
//    switch (randomNumber)
//    {
//        case 1:
//            Console.WriteLine(sual1[1]);
//            for (int i = 0; i < 3; i++)
//            {
//                if (Console.ReadLine().ToUpper() == sual1[0])
//                {
//                    Console.ForegroundColor = ConsoleColor.Green;
//                    Console.WriteLine(correct);
//                    Console.ResetColor();
//                    isTrue = true;
//                    break;
//                }
//                else
//                {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine(notCorrect + (2 - i));
//                    Console.ResetColor();
//                }
//            }
//            break;
//        case 2:
//            Console.WriteLine(sual2[1]);
//            for (int i = 0; i < 3; i++)
//            {
//                if (Console.ReadLine().ToUpper() == sual2[0])
//                {
//                    Console.ForegroundColor = ConsoleColor.Green;
//                    Console.WriteLine(correct);
//                    Console.ResetColor();
//                    isTrue = true;
//                    break;
//                }
//                else
//                {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine(notCorrect + (2 - i));
//                    Console.ResetColor();
//                }
//            }
//            break;
//        case 3:
//            Console.WriteLine(sual3[1]);
//            for (int i = 0; i < 3; i++)
//            {
//                if (Console.ReadLine().ToUpper() == sual3[0])
//                {
//                    Console.ForegroundColor = ConsoleColor.Green;
//                    Console.WriteLine(correct);
//                    Console.ResetColor();
//                    isTrue = true;
//                    break;
//                }
//                else
//                {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine(notCorrect + (2 - i));
//                    Console.ResetColor();
//                }
//            }
//            break;
//    }
//    if (!isTrue)
//    {
//        Console.ForegroundColor = ConsoleColor.Yellow;
//        Console.WriteLine(lose);
//        Console.ResetColor();
//    }
//    Console.WriteLine("Yeniden oynamaq isteyirsiz? y/n");
//    if (Console.ReadLine() != "y")
//    {
//        Console.WriteLine("Sag olun!");
//        Console.ForegroundColor = ConsoleColor.Black;
//        break;
//    }
//    Console.Clear();
//}

//29 
//for (int i = 0; i < 100; i++)
//{
//    if((i+1)%10==7 || (i + 1) % 7 == 0)
//    {
//        Console.Write("DIZZ ");
//    }
//    else
//    {
//        Console.Write((i+1)+" ");
//    }
//}

//30
//using System.Diagnostics;

//int[] numbers = [10, 12, 22, 10, 32, 22, 16, 32, 22, 10, 11, 23, 32, 10, 10, 23, 23, 15];
//int uniqueCount = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    int selectedNumber = numbers[i];
//    bool isDublicate = false;
//    for (int d = 0; d < i; d++)
//    {
//        if (selectedNumber == numbers[d])
//        {
//            isDublicate = true;
//            break;
//        }
//    }
//    if (isDublicate == false)
//    {
//        uniqueCount++;
//    }
//}
//Console.WriteLine("Fərqli ədədlərin sayı: " + uniqueCount);

//31

//32

//33