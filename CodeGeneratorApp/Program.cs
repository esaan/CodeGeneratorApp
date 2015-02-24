using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Console.WriteLine("master branch");
            Console.WriteLine("added in  github console");
            Console.ReadLine();
        }

        static void Add()
        {            
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            int sum = int.Parse(num1) + int.Parse(num2);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
