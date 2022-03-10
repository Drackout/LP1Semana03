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

            Console.WriteLine($"String : {stringPedida}");
            Console.WriteLine($"Char: {charPedida}");

            for(int i = 0; i < stringPedida.Length; i++)
            {
                if(stringPedida[i] != charPedida)
                {
                    Console.Write(stringPedida[i]);
                }
            }

        }
    }
}
