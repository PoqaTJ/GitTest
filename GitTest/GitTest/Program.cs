using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> strings = new List<String>() { "Git over here!", "The Gittysburg Address", "Gitar Hero" };
            Random rand = new Random();

            Console.WriteLine("Hello, world!");
            Console.WriteLine();

            Console.WriteLine(strings[rand.Next(strings.Count)]);
            Console.ReadLine();
        }
    }
}
