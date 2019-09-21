using ClassFundamentals.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            calculator.Add(1, 2);
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
    
    
}
