using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2
{
    public delegate void Greet(string input);
    class Program
    {
        static void Main(string[] args)
        {
            Greet obj = delegate (string input)
            {
                Console.WriteLine("Hi " + input + ", Good Morning!");
            };

            obj("Sharan");

            Console.ReadKey();
        }
    }
}
