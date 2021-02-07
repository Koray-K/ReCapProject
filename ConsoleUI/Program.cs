using System;
using Business.Concrete;
using DataAccess.Concrete.InMemoryCarDal;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelName);
                Console.WriteLine(car.ModelYear);
            }
        }
    }
}
