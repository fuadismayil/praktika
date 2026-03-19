

using taskinterfaces.Interfaces;
using taskinterfaces.Models;

namespace taskinterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 */
            Dog dog = new Dog();
            dog.MakeSound();
            Cat cat = new Cat();
            cat.MakeSound();
            Console.WriteLine();



            /* 2 */
            Car car = new()
            {
                Brand = "Toyota"
            };
            car.Drive();
            Bus bus = new()
            {
                Brand = "Mercedes"
            };
            bus.Drive();
            Console.WriteLine();



            /* 3 */
            Duck duck = new Duck();
            duck.Fly();
            duck.Swim();
            Console.WriteLine();



            /* 4 */
            List<IShape> shapes = new List<IShape>();
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            shapes.Add(circle);
            shapes.Add(new Circle(10));
            shapes.Add(rectangle);
            shapes.Add(new Rectangle(10, 5));
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"Shape {i+1} {shapes[i].GetType().Name} Area: {shapes[i].GetArea()}");
            }
            Console.WriteLine();



            /* 5 */
            CardPayment cardPayment = new()
            {
                CardHolderName = "Murad Muradov",
                CardNumber = "1234 5678 9012 3456",
                ExpiryDate = "12/27",
                CVV = 585
            };
            cardPayment.Pay(100.0);
            CashPayment cashPayment = new();
            cashPayment.Pay(50.0);
            Console.WriteLine();



            /* 6 */
            FileLogger fileLogger = new();
            fileLogger.Log("This is a log message for FileLogger.");
            ConsoleLogger consoleLogger = new();
            consoleLogger.Log("This is a log message for ConsoleLogger.");
            Console.WriteLine();



            /* 7 */
            Developer developer = new("Murad");
            developer.Work();
            Console.WriteLine($"Developer's salary: {developer.GetSalary()}");
            Manager manager = new("Fuad");
            Console.WriteLine($"Manager's salary: {manager.GetSalary()}");
            manager.Work();
        }
    }
}