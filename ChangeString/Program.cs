using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char ch = char.Parse(Console.ReadLine());

            foreach (var w in word)
            {
                if (w == ch)
                    Console.Write("x");
                else
                    Console.Write(w);
            }
        }
    }
}
