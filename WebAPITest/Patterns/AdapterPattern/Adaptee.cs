using System;

namespace WebAPITest.Patterns.AdapterPattern
{
    public class Adaptee
    {
        public void MethodB()
        {
            Console.WriteLine("MethodB called");
        }
    }
}
