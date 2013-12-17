using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my little Program!");
            Console.WriteLine("Please write a number! In Words!");
            string Number1;
            Number1 = Console.ReadLine();
            Console.WriteLine("Oh! Your number is " + Number1 + "! Well that´s cool!");
            
            if(Number1) 
            Console.WriteLine("You´re Lucky! You typed in " + Number1 + );
            
            Console.Read();
        }
    }
}
