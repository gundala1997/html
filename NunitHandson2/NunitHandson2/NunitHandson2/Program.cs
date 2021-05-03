using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitHandson2
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            int x = a + b;
            return x;
        }
        public int Substract(int a, int b)
        {
            int x = a - b;
            return x;
        }
        public int Multiply(int a, int b)
        {
            int x = a * b;
            return x;
        }
        public int Divide(int a, int b)
        {
            int x = a / b;
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
