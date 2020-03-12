using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SportCar jaguar = new SportCar(2020, "Jaguar F-Pace", 3.0);
            jaguar.SetFuelConsumptionPer100(9);

            try
            {
                (jaguar as ISportCar98).Fill(10);
                ((ISportCar98) jaguar).Fill(15);
            }
            catch (SportCarException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Try to refill with less fuel");
            }
            finally
            {
                Console.WriteLine(String.Format("Current fuel capacity: {0}", jaguar.Fuel));
            }
            SportCarExtensions.TuneUp(jaguar, 25);
            Console.WriteLine(jaguar.Power);

            jaguar.SetProductionDay(Days.Monday);


            int a = 1;
            int b = a++;
            int c = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
