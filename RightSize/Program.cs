using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string item in args)
            {
                if (item.Length >= 8)
                {
                    //teste
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                if(item.Length > 3)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
