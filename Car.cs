using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAnyObject
{
    class Car : SortBase
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public override bool SortArray(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if ((array[j] as Car).Speed > (array[j + 1] as Car).Speed)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
