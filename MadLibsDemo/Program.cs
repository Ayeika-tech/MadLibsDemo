using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, adjective, noun;

            Console.Write("Enter a name ");
            name = Console.ReadLine();
            Console.Write("Enter an adjetive ");
            adjective = Console.ReadLine();
            Console.Write("Enter a noun ");
            noun = Console.ReadLine();

            Console.WriteLine("Please excuse " + name + " , who is ");
            Console.WriteLine("far too " + adjective + " to attend " + noun + " class.");


            Console.ReadLine();
        }
    }
}
