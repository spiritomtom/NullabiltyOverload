using NullabilityTest;
using System;

namespace NullabillityTest
{
    public class Program
    {
        public static void Main()
        {
            var tc = new TestClass();
            var guidArray = (Guid[]?)new Guid[3];

            tc += guidArray;

        }
    }
}