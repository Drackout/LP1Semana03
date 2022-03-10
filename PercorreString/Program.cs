using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringPedida;
            char charPedida;
            Console.Write("String->");
            stringPedida = Console.ReadLine();

            Console.Write("Char->");
            charPedida = char.Parse(Console.ReadLine());

            Console.WriteLine($"String inteira: {stringPedida}");
            Console.WriteLine($"Char: {charPedida}");

            Console.WriteLine("String sem char");
        }
    }
}
