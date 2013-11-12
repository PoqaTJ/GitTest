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
            List<String> strings = new List<String>() { "Git over here!", "The Gittysburg Address", "Gitar Hero" }; // Add strings here with commas between and surrounded by "quotes"!
            Random rand = new Random(); // This is a Random. I will use it later to do stuff randomly. Spork optional.

            Console.WriteLine("Hello, world!"); // http://en.wikipedia.org/wiki/Hello_world_program
            Console.WriteLine(); // writes a blank line

            Console.WriteLine(strings[rand.Next(strings.Count)]); // And this is why it's nice that the upper bound for Random.Next() is exclusive.
            Console.ReadLine(); // This makes it so the console doesn't close right away.
        }
    }
}
