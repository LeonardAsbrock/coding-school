using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cars
{
    class Manufacturer
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Car BuildCar(string model, int ps, int size, CarType carType)
        {
            Tire tire = new Tire(size);
            List<Tire> tires = new List<Tire>();
            for (int i = 0; i <= 3; i++)
            {
                tires.Add(tire);
            }
            List<Door> doors = new List<Door>();
            if (carType == CarType.Limousine)
            {
                for (int i = 0; i < (int)CarType.Limousine; i++)
                {
                    Door door = new Door();
                    doors.Add(door);
                }
            }
            else if(carType == CarType.Coupe)
            {
                for (int i = 0; i < (int)CarType.Coupe; i++)
                {
                    Door door = new Door();
                    doors.Add(door);
                }
            }
            Engine engine = new Engine(ps);
            string serialNumber = Guid.NewGuid().ToString();
            Car car = new Car(model, engine, this, tires, serialNumber, doors);
            return car;
        }
        private Manufacturer() { }
        public Manufacturer(string name)
        {
            this.Name = name;
        }
    }
}
