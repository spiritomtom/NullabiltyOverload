using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullabilityTest
{
    internal class TestClass
    {
        public static TestClass operator+ (TestClass x, Guid[]? y)
        {
            return new TestClass();
        }
    }
}
