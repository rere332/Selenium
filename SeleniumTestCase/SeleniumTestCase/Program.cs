using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTestCase
{
    public class Program
    {

        public static void Main(string[] args)
        {
            bool result = true;
            TestClass testDemo = new TestClass();
            testDemo.SetupTest();
            testDemo.Steps();
            result=testDemo.Verify();
            testDemo.CleanUp();
        }
    }
}
