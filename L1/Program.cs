using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public sealed class Test : AbstarctClass, ITest, ITest2
    {
        public int Age { get; set; }
        public String Name { get; set; }
        public double Result { get; set; }
        public int Cnt { get; }
        public int Cnt2 { get; private set; }
        public string Color { get; set; }

        private int count;
        private string lastName;

        public static int ObjectsCount;

        public Test(int age, string name, double result)
        {
            Age = age;
            Name = name;
            Result = result;
            ObjectsCount++;
        }

        public Test()
        {
            ObjectsCount++;
        }
        public int Increase(int first)
        {
            return first++;
        }
        public void Print()
        {
            Console.WriteLine("Call from method Print");
        }
        public static int GetObjects()
        {
            return ObjectsCount;
        }
        public override void Method1()
        {
            Console.WriteLine("Overrided Method1");
        }
        public override void Method2()
        {
            Console.WriteLine("Overrided Method2");
        }
        void ITest.DoWork()
        {
            Console.WriteLine("Do some work from ITest");
        }
        void ITest2.DoWork()
        {
            Console.WriteLine("Do some work from ITest2");
        }
        public override string ToString()
        {
            return String.Format("Name:{0}, Age:{1}, Result:{2}", Name, Age, Result);
        }

        public override bool Equals(object obj)
        {
            return obj != null &&
                obj is Test test &&
                Age == test.Age &&
                Name == test.Name &&
                Result == test.Result &&
                Color == test.Color;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Test test = new Test();
            try
            {
                (test as ITest2).DoWork();
                ((ITest) test).DoWork();
            }
            catch (CustomTestException e)
            {
                
            }
            finally
            {

            }
            int a = 1;
            int b = a++;
            int c = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            a.Add(20);
            Console.WriteLine(a);
            Console.ReadLine();
            

        }
    }
}
