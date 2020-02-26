using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cars
{
    class Car
    {
        private Manufacturer _manufacturer;

        public Manufacturer Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        private Engine _engine;

        public Engine Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private List<Tire> _tires;

        public List<Tire> Tires
        {
            get { return _tires; }
            set { _tires = value;}
        }
        
        private List<Door> _doors;

        public List<Door> Doors
        {
            get { return _doors; }
            set { _doors = value;}
        }

        private string _serialNumber;
        
        public string SerialNumber
        {
            get { return _serialNumber;  }
            set { _serialNumber = value; }
        }
        private Car() { }

        public Car(string model, Engine engine, Manufacturer manufacturer, List<Tire> tires, string serialNumber, List<Door> doors)
        {
            this.Model = model;
            this.Engine = engine;
            this.Manufacturer = manufacturer;
            this._tires = tires;
            this.SerialNumber = serialNumber;
            this.Doors = doors;
        }
        public void Drive()
        {
            Console.WriteLine();
        }

    }
}
