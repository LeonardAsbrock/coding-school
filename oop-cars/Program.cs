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

            Car car1 = BMW.BuildCar("520", 230, 20, CarType.Coupe);
            Car car2 = BMW.BuildCar("325", 230, 20, CarType.Limousine);
            Car car3 = Audi.BuildCar("A3", 230, 20, CarType.Coupe);
            Car car4 = Audi.BuildCar("A7", 230, 20, CarType.Limousine);

            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            cars.Add(car1.SerialNumber, car1);
            cars.Add(car2.SerialNumber, car2);
            cars.Add(car3.SerialNumber, car3);
            cars.Add(car4.SerialNumber, car4);

            foreach (var car in cars)
            {
                if (car.Value.Doors.Count == (int)CarType.Coupe)
                {
                    Console.WriteLine($"Engage: {car.Value.Manufacturer.Name}\t{car.Value.Model}\t{car.Value.Doors.Count}\t {car.Key}");
                }
            }
        }
    }
}
