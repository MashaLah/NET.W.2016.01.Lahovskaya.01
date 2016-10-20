using System;
using Car;

class Program
{
   static void Main()
   {
       Auto auto = new Auto();
       auto.AutoInfo();

       SportCar sportCar = new SportCar();
       sportCar.SportCarInfo();

       Console.ReadLine();
   }
}