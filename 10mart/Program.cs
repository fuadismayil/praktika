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
string[] sual1 = ["ALMA", "Bu bir meyvedir."];
string[] sual2 = ["KITAB", "Bu tehsile aid bir esyadir."];
string[] sual3 = ["MONITOR", "Bu komputerin esas hisselerinden biridir."];
string correct = "Duz tapdiniz!!!";
string notCorrect="Yanlis!!! qalan cehd sansiniz: ";
bool isTrue = false;

while (true)
{
    Random rand = new Random();
    int randomNumber = rand.Next(1, 4);
    switch (randomNumber)
    {
        case 1:
            Console.WriteLine("Bu bir meyvedir. 3 cehd sansin var!");
            for (int i = 0; i < 3; i++)
            {
                if (Console.ReadLine().ToUpper() == sual1[1])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correct);
                    Console.ForegroundColor = ConsoleColor.White;
                    isTrue = true;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(notCorrect + (2 - i));
                    Console.ForegroundColor = ConsoleColor.White;
                    isTrue = false;
                }
            }
            if (!isTrue)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Meqlub odunuz, bexdinizi bir daha sinayin!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Yeniden oynamaq isteyirsiz? y/n");
                if (Console.ReadLine() == "y")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("saqolun");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Environment.Exit(0);
                }
                break;
            }
            break;
        case 2:
            Console.WriteLine("Bu tehsile aid bir esyadir. 3 cehd sansin var!");
            for (int i = 0; i < 3; i++)
            {
                if (Console.ReadLine().ToUpper() == "KITAB")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correct);
                    Console.ForegroundColor = ConsoleColor.White;
                    isTrue = true;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(notCorrect + (2 - i));
                    Console.ForegroundColor = ConsoleColor.White;
                    isTrue = false;

                }
            }
            if (!isTrue)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Meqlub odunuz, bexdinizi bir daha sinayin!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Yeniden oynamaq isteyirsiz? y/n");
                if (Console.ReadLine() == "y")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("saqolun");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Environment.Exit(0);
                }
                break;
            }
            break;
        case 3:
            Console.WriteLine("Bu komputerin esas hisselerinden biridir. 3 cehd sansin var!");
            for (int i = 0; i < 3; i++)
            {
                if (Console.ReadLine().ToUpper() == "MONITOR")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correct);
                    Console.ForegroundColor = ConsoleColor.White;
                    isTrue = true;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(notCorrect + (2 - i));
                    Console.ForegroundColor = ConsoleColor.White;
                    isTrue = false;

                }
            }
            if (!isTrue)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Meqlub odunuz, bexdinizi bir daha sinayin!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Yeniden oynamaq isteyirsiz? y/n");
                if (Console.ReadLine() == "y")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("saqolun");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Environment.Exit(0);
                }

                break;
            }
            break;
    }

    
}



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

