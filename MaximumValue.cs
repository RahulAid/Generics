using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaximumValue
    {
        public string firstValue;
        public string secondValue;
        public string thirdValue;

        public MaximumValue(string firstValue, string secondValue, string thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public static string MaximumStringValue(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine("Maximum Number is :" + firstValue);
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
               secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
               secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine("Maximum Number is :" + secondValue);
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
               thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
               thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                Console.WriteLine("Maximum Number is :" + thirdValue);
            }
            return firstValue;
        }
    }
}