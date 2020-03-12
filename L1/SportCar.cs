using System;

namespace L1
{
    public sealed class SportCar : Car, ISportCar95, ISportCar98
    {
        public int Year { get; set; }
        public String Model { get; set; }
        public double Engine { get; set; }
        public int FuelMaxLevel { get;  }
        public double Fuel { get; private set; }
        public string Color { get; set; }
        public Days ProductionDay { get; private set; }

        public int Power { get; set; }

        private double fuelConsumption;
        private int id;
        private double milage;
      

        public static int CarsProduced;
        private static int uniqueId;

        public SportCar(int year, string model, double engine)
        {
            Year = year;
            Model = model;
            Engine = engine;
            FuelMaxLevel = 70;
            Power = 250;
            id = ++uniqueId;
            CarsProduced++;
        }
        public void SetFuelConsumptionPer100(double consume)
        {
            if (consume > 0D && consume < 25D) {
                fuelConsumption = consume;
            }
        }

        public static int GetCarsProduced()
        {
            return CarsProduced;
        }
        public override string ToString()
        {
            return String.Format("Year:{0}, Model:{1}, Engine:{2}, Color:{3}", Year, Model, Engine, Color);
        }

        public override void Drive(int distance)
        {
            if (Fuel >= fuelConsumption / 100 * distance)
            {
                StartEngine();
                milage += distance;
                Fuel -= fuelConsumption / 100 * distance;
            }
            else
            {
                Console.WriteLine("Not enough fuel");
                StopEngine();
            }
        }

        public override bool Equals(object obj)
        {
            var car = obj as SportCar;
            return car != null &&
                   Year == car.Year &&
                   Model == car.Model &&
                   Engine == car.Engine &&
                   id == car.id;
        }

        void ISportCar95.Fill(int amount)
        {
            Console.WriteLine("Filling in 95 fuel");
            Fill(amount);
        }

        void ISportCar98.Fill(int amount)
        {
            Console.WriteLine("Filling in 98 fuel");
            Fill(amount);
            
        }
        public void SetProductionDay(Days day)
        {
            ProductionDay = day;
        }
        private void Fill(int amount)
        {
            if (Fuel + amount < FuelMaxLevel)
            {
                Fuel += amount;
            }
            else
            {
                throw new SportCarException("Fuel overload!!!");
            }
        }

    }
}
