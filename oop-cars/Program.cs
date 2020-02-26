using System;
using System.Collections.Generic;

namespace oop_cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Manufacturer BMW = new Manufacturer("BMW");
            Manufacturer Audi = new Manufacturer("Audi");
            List<Car> cars = new List<Car>();
            Car car1 = BMW.BuildCar("520", 230, 20, global::CarType.Coupe);
            Car car2 = BMW.BuildCar("325", 230, 20, global::CarType.Limousine);
            Car car3 = Audi.BuildCar("A3", 230, 20, global::CarType.Coupe);
            Car car4 = Audi.BuildCar("A7", 230, 20, global::CarType.Limousine);
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            foreach (var car in cars)
            {
                Console.WriteLine($"Engage: {car.Manufacturer.Name}\t{car.Model}\t{car.Doors.Count}\t {car.SerialNumber}");
            }
        }
    }
}
