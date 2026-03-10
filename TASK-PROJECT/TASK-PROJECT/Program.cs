Console.WriteLine("kubunu oyrenmek istediyiniz ededi daxil edin:");
int numberFromUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("daxil etdiyiniz ededin kubu: " + numberFromUser * numberFromUser * numberFromUser);
﻿
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 0)
{
    Console.WriteLine("Musbet");
}
else
{
    Console.WriteLine("Menfi");
}