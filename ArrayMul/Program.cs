using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //
            Console.WriteLine($"a1");
            float[][] arr1 = new float[2][];
            arr1[0] = new float[2] {float.Parse(args[0].Replace(".",",")), float.Parse(args[1].Replace(".",","))};
            arr1[1] = new float[2] {float.Parse(args[2].Replace(".",",")), float.Parse(args[3].Replace(".",","))};

            float[] arr2 = new float[2];
            arr2[0] = float.Parse(args[4].Replace(".",","));
            arr2[1] = float.Parse(args[5].Replace(".",","));

            // Took waaaaay too much time with the "Globalizaton" thing
            // Still didn't work correctly.. here's an improv 
            float sumVals;

            for (int i = 0; i < arr1.Length; i++)
            {
                sumVals = 0f;
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    sumVals += arr1[i][j] * arr2[j];
                }
                Console.WriteLine($"| {sumVals,7:f2} |");
            }
        }
    }
}
