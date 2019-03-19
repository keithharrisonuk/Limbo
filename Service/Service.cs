using System;

namespace Services
{
    public class Service
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        
        public int Add(int a, int b)
        {
            // are you sure this works with negative numbers?
            return a + b;
        }
    }
}
