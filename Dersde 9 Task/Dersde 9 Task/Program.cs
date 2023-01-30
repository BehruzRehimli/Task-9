using System;
using _2ci_Task_uchun;
namespace Dersde_9_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(40, 0.13, 200);
            car1.AddFuel(25);
            car1.AddFuel(20);
            car1.Drive(150);
            Console.WriteLine(car1.MillAge);





            Student st1 = new Student();
            st1.Age = 14;
            Console.WriteLine(st1.Age);




            Drink beer= new Drink();
            beer.Name = "NZS";
            beer.AlcoholPercent = 111;
            beer.Price= 100;

            Console.WriteLine(beer.Name);
            Console.WriteLine(beer.AlcoholPercent);
            Console.WriteLine(beer.Price);  
        }
    }
}
