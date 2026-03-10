//// 1) iki ededin boyuyunu tapan alqoritim, ededler console readline den gelecek
//Console.WriteLine("birinci ededi daxil edin:");
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("ikinci ededi daxil edin:");
//int secondNumber = Convert.ToInt32(Console.ReadLine());
//if (firstNumber > secondNumber)
//{
//    Console.WriteLine("daxil edilen ededlerden boyuk olan eded:" + firstNumber);
//}
//else if (secondNumber > firstNumber) { Console.WriteLine("daxil edilen ededlerden boyuk olan eded:" + secondNumber); }
//else
//{
//    Console.WriteLine("ededler beraberdir");
//}

//// 2) verilen ededin 2e qaliqsiz bolunub bolunmediyini yoxlayan alqoritim yazaq readline ile
//Console.WriteLine("2 ye qaliqsiz bolunub bolunmediyini yoxlamaq istediyiniz ededi daxil edin");
//if (Convert.ToInt32(Console.ReadLine()) % 2 == 0)
//{
//    Console.WriteLine("daxil edilen reqem 2 ye qaliqsiz bolunur");
//}
//else
//{
//    Console.WriteLine("daxil edilen reqem 2 ye qaliqsiz bolunmur");
//}

//// 3) consoldan daxil edilen reqemin 100 den boyuk beraber boyukl mesaji kicikdirse kicik mesaji cixsin
//if (Convert.ToInt32(Console.ReadLine()) >= 100)
//{
//    Console.WriteLine("boyuk");
//}
//else { Console.WriteLine("kicik"); }

//// 4) konsoldan daxil edilen yasin 18 den boyuk adult kicikdirse child yazan alqoritm
//int age = Convert.ToInt32(Console.ReadLine());
//if (age >= 18)
//{
//    Console.WriteLine("Adult");
//}
//else { Console.WriteLine("child"); }

//// 5) konsoldan daxil edilen ededin menfi mujsbet olmasinin yoxlanmasi
//int importedNumber = Convert.ToInt32(Console.ReadLine());
//if (importedNumber > 0)
//{
//    Console.WriteLine("musbet");
//}
//else if (importedNumber < 0)
//{
//    Console.WriteLine("menfi");
//}
//else
//{
//    Console.WriteLine("0 ne menfi ne musbetdir");
//}

//// 6) heftenin gunleri
//Console.WriteLine("Import the number of the week whose name you want to learn:");
//int importedWeekDay = Convert.ToInt32(Console.ReadLine());
//switch (importedWeekDay)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thrusday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Wrong week day number imported");
//        break;
//}
//;

//// 7) daxil edilen ededin kubunu hesablayan alqoritm 
//Console.WriteLine("kubunu oyrenmek istediyiniz ededi daxil edin:");
//int numberFromUser = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("daxil etdiyiniz ededin kubu: " + numberFromUser * numberFromUser * numberFromUser);

//// 8) aylarin gunlerini cixaran alqoritim
//Console.WriteLine("Ayin gun sayini gormek ucun sira nomresini daxil et:");
//int importedMonth = Convert.ToInt32(Console.ReadLine());
//switch (importedMonth)
//{
//    case 1:
//        Console.WriteLine("Yanvar: 31 gun");
//        break;
//    case 2:
//        Console.WriteLine("Fevral: 28-29 gun");
//        break;
//    case 3:
//        Console.WriteLine("Mart: 31 gun");
//        break;
//    case 4:
//        Console.WriteLine("Aprel: 30 gun");
//        break;
//    case 5:
//        Console.WriteLine("May: 31 gun");
//        break;
//    case 6:
//        Console.WriteLine("Iyun: 30 gun");
//        break;
//    case 7:
//        Console.WriteLine("Iyul: 31 gun");
//        break;
//    case 8:
//        Console.WriteLine("Avqust: 31 gun");
//        break;
//    case 9:
//        Console.WriteLine("Sentyabr: 30 gun");
//        break;
//    case 10:
//        Console.WriteLine("Oktyabr: 31 gun");
//        break;
//    case 11:
//        Console.WriteLine("Noyabr: 30 gun");
//        break;
//    case 12:
//        Console.WriteLine("Dekabr: 31 gun");
//        break;
//    default:
//        Console.WriteLine("Bele bir ay yoxdur!");
//        break;
//}
//;

//// 9) Fruits arrayi yaradib ona 7 meyve elave etmek
//string[] fruitsArray = { "Apple", "Pineapple", "Banana", "Pomegranade", "Grape", "Pear", "Water melon" };

//// 10) students ve 10 student adi
//string[] studentsArray = { "James", "Michael", "Christopher", "Matthew", "Joshua", "Daniel", "Anthony", "William", "David", "Alexander" };

//// 11) studentlerin adin cap etmek
//for (int i=0;  i<studentsArray.Length; i++)
//{
//    Console.WriteLine(studentsArray[i]);
//}

//// 12) studentlerin 5 cisini
//Console.WriteLine(studentsArray[4]);

//// 13) seherler arrayi
//string[] cities = { "Baku", "Ganja", "Sumqayit", "Mingachevir", "Lankaran", "Shaki", "Shirvan", "Nakhchivan", "Quba", "Shamakhi" };

//// 14) 3e bolunen ededolerin cixsarilmasi
//int[] numbers = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
//for (int  i = 0;  i < numbers.Length;  i++)
//{
//    if (numbers[i] % 3 == 0)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}

//// 15) yuxardaki arrayin ,minimumu maksimumu ve ededi ortasini tapilmasi alqoritmi
//Console.WriteLine(numbers.Min());
//Console.WriteLine(numbers.Max());
//Console.WriteLine(numbers.Sum() / numbers.Length);

// armstrong tapilmasi
//int num = Convert.ToInt32(Console.ReadLine());
//int temp = num;
//double a = 0;
//double b = 0;
//while (temp > 0)
//{
//    b = temp % 10; 
//    a = a + Math.Pow(b, 3); 
//    temp = temp / 10; 
//}
//if (a == num)
//{
//    Console.WriteLine("Armstrong ededdir");
//}
//else{
//    Console.WriteLine("Armstrong deyil");
//}
//int sum = 0;
//string number = Console.ReadLine();
//for (int i = 0; i<number.Length; i++)
//{
//    char a = number[i];
//    int x = a- '1';

//    Console.WriteLine(x);
//}

// 1 den 500 e qeder ededlerin icerisinde tek ededlerin cemi ile cut ededlerin ceminin ferqini tapib cavabin musbet yada menfi olduqunu tapacaqiq
//int a = 1;
//int cut = 0;
//int tek = 0;
//while (a <= 500)
//{
//    if (a % 2 == 0)
//    {
//        cut += a;
//    }
//    else { tek += a; }
//    a++;
//}
//if (tek - cut > 0)
//{
//    Console.WriteLine(tek-cut + " musbet");
//} else if (tek - cut < 0)
//{
//    Console.WriteLine(tek-cut + " menfi");
//}
//else
//{
//    Console.WriteLine(0);
//}


// ilk 10 fibanocci ededlweini yazan alqoritim
//int f = 0;
//int s = 1;
//int[] fib = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    fib[i] = f;
//    int c = f + s;
//    f = s;
//    s = c;
//}
//for (int i = 0; i < fib.Length; i++)
//{
//    Console.Write(fib[i] + " ");
//}


//faktoriyal hesablayan
//int number = Convert.ToInt32(Console.ReadLine());
//int a = 1;
//for (int i = 1; i <= number; i++)
//{
//    a = a * i;
//}
//Console.WriteLine(a);


// adlari tersine
//string word = Console.ReadLine();
//string reverseWord = "";
//for  (int i = word.Length-1 ; i>=0; i--)
//{
//    reverseWord += word[i];
//}
//Console.WriteLine(reverseWord);



//03/05/2025 mesqele




//16  ededin ancaq 1e ve ozune bolunub bolunmediyini yoxlayan alqoritim
//int number = Convert.ToInt32(Console.ReadLine());


//17 arrayda 6 ya bolunnenneri ekrana cixarsin

//int[] givenArray = [23, 60, 12, 43, 56, 100, 23, 43, 21, 36, 72];
//for (int i = 0; i < givenArray.Length; i++)
//{
//    if (givenArray[i] % 6 == 0)
//    {
//        Console.WriteLine(givenArray[i]);
//    }
//}


////18 calculator
//Console.WriteLine("enter formula you want (+, -, *, /, %, ^):");
//char selectedFormula = ' ';
//int power = 0;
//double firstNum = 0;
//double secondNum = 0;
//char formula = Convert.ToChar(Console.ReadLine());
//while (true)
//{
//    switch (formula)
//    {
//        case '+':
//            Console.WriteLine(formula + " selected.");
//            Console.WriteLine("please enter first number:");
//            firstNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("please enter second number:");
//            secondNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("answer is: " + (firstNum + secondNum));
//            break;
//        case '-':
//            Console.WriteLine(formula + " selected.");
//            Console.WriteLine("please enter first number:");
//            firstNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("please enter second number:");
//            secondNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("answer is: " + (firstNum - secondNum));
//            break;
//        case '*':
//            Console.WriteLine(formula + " selected.");
//            Console.WriteLine("please enter first number:");
//            firstNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("please enter second number:");
//            secondNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("answer is: " + (firstNum * secondNum));
//            break;
//        case '/':
//            Console.WriteLine(formula +" selected.");
//            Console.WriteLine("please enter first number:");
//            firstNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("please enter second number:");
//            secondNum = Convert.ToInt32(Console.ReadLine());
//            if (secondNum == 0)
//            {
//                Console.WriteLine("you cant divide 0");
//                break;
//            }
//            Console.WriteLine("answer is: " + (firstNum / secondNum));
//            break;
//        case '%':
//            Console.WriteLine(formula + " selected.");
//            Console.WriteLine("please enter first number:");
//            firstNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("please enter second number:");
//            secondNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("answer is: " + (firstNum % secondNum));
//            break;
//        case '^':
//            Console.WriteLine(formula + " selected.");
//            Console.WriteLine("please enter number:");
//            firstNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("please enter power number:");
//            power = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("answer is: " + Math.Pow(firstNum, power));
//            formula = ' ';
//            break;
//        default:
//            Console.WriteLine("error, wrong formula selected, please try again!");
//            break;
//    }
//}

////19 endirim
//double[] prices = [100.0,1300.50,259.99,430.30,160.99,320.9];
//for(int i=0; i < prices.Length; i++)
//{
//    prices[i] = prices[i] * .8;
//}
//for (int i=0;i < prices.Length; i++)
//{
//    Console.Write(prices[i]+" ");
//}

//22 oyun 1-100 arasinda cehd tapsa you won tapmasa game over
//Random rnd = new Random();
//int randomNumber = rnd.Next(1, 101);
//Console.WriteLine(randomNumber);
//int gameState = 0;
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Guess the number between 1-100 , you have {5-i} attempts left :");
//    int guess = Convert.ToInt32(Console.ReadLine());
//    if (guess==randomNumber)
//    {
//        Console.WriteLine("You Won");
//        gameState = 1;
//        break;
//    }
//    else if(guess != randomNumber && i!=4)
//    {
//        Console.WriteLine("Try again");
//        gameState = 0;
//    }
//    else
//    {
//        gameState = 0;
//        break;
//    }
//}
//if (gameState == 0)
//{
//    Console.WriteLine("Game Over");
//}
// 24 pelindrone check stringle
//string input = Console.ReadLine();
//if (input[input.Length - 1] == input[0]){
//    Console.WriteLine("the number is pelindrone");
//}
//else{
//    Console.WriteLine("the number isn't pelindrone");
//}

//24 pelindrone stringsiz
//var input = Console.ReadLine();
//if (input[0] == input[input.Length - 1])
//{
//    Console.WriteLine("the number is pelindrone");
//}
//else
//{
//    Console.WriteLine("the number isn't pelindrone");
//}

//24 real palindron
//int input = Convert.ToInt32(Console.ReadLine());

// fruits alma 2.5azn armud 3azn heyva 4.5 azn kivi 6azn, ilk ad sonra kilo
//Console.WriteLine("almaq istediyiniz veyveni secin: 1) Alma 2)Armud 3)Heyva 4)Kivi");
//string fruit = Console.ReadLine();
//Console.WriteLine("Neche kiloqram?");
//double weight = Convert.ToDouble(Console.ReadLine());
//switch (fruit)
//{
//    case "1":
//        Console.WriteLine($"{weight}Kq Alma Qiymet: " + 2.5 * weight + "azn");
//        break;
//    case "2":
//        Console.WriteLine($"{weight}Kq Armud Qiymet: " + 3 * weight + "azn");
//        break;
//    case "3":
//        Console.WriteLine($"{weight}Kq Heyva Qiymet: " + 4.5 * weight + "azn");
//        break;
//    case "4":
//        Console.WriteLine($"{weight}Kq Kivi Qiymet: " + 6 * weight + "azn");
//        break;
//    default:
//        Console.WriteLine("Duzgun meyveni sechin");
//        break;
//}

// verilmis n ededinin 2 nin quvveti olub olmamasini yoxlayin
//Console.WriteLine("insert number");
//double num = Convert.ToDouble(Console.ReadLine());
//double test = num;
//while (test > 0)
//{
//    test /= 2;
//    if (test == 1)
//    {
//        break;
//    }
//}
//if (test == 1)
//{
//    Console.WriteLine(num + " 2nin quvvetidir");
//}
//else
//{
//    Console.WriteLine(num+ " 2nin quvveti deyil");
//}

// pensiya 300azn, 1- balans goster, 2- balansa deposit, 3- balansdan withdraw, 4- exit
//Console.BackgroundColor = ConsoleColor.White;
//Console.Clear();
//double balance = 300;
//while (true)
//{
//    Console.ForegroundColor = ConsoleColor.Black;
//    double deposit = 0;
//    double withdraw = 0;
//    Console.WriteLine("select process: 1-show balance, 2-deposit, 3-withdrawal, 4-exit");
//    int selectedProcess = Convert.ToInt32(Console.ReadLine());
//    switch (selectedProcess)
//    {
//        case 1:
//            Console.WriteLine("Your current Balance: " + balance + " Azn");
//            break;
//        case 2:
//            Console.WriteLine("Enter amount of deposit: ");
//            deposit = Convert.ToDouble(Console.ReadLine());
//            balance += deposit;
//            Console.WriteLine($"+{deposit} Azn, Your current balance: " + balance + " Azn");
//            break;
//        case 3:
//            Console.WriteLine("Enter amount of withdraw: ");
//            withdraw = Convert.ToDouble(Console.ReadLine());
//            if (withdraw > balance)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("You don't have enough balance.");
//                break;
//            }
//            else
//            {
//                balance -= withdraw;
//                Console.WriteLine($"-{withdraw} Azn, Your current balance: " + balance + " Azn");
//                break;
//            }
//        case 4:
//            Console.WriteLine("GoodBye");
//            Environment.Exit(0);

//            break;
//        default:
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Please select correct process");
//            break;
//    }
//}


