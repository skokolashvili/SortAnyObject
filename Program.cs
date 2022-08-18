using System;

namespace SortAnyObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] car1 =
            {
                new Car{Model = "Mercedec", Speed = 240},
                new Car{Model = "BMW", Speed = 260 },
                new Car{Model = "Ford", Speed = 220},
                new Car{Model = "Alfa Romeo", Speed = 280},
            };
            Console.WriteLine(ArrayBool(car1)); 
        }

        static bool ArrayBool(object[] array)
        {
            SortBase obj = new SortBase();
            if (obj.SortArray(array))
            {
                return true;
            }
            return false;
        }
    }
}
