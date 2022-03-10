using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            int dhoriz; 
            int vhoriz;
            int i=0;
            int j=0;

            Console.WriteLine("insira a dimensao horizontal e vertical do array");
            dhoriz = Int32.Parse(Console.ReadLine());
            vhoriz = Int32.Parse(Console.ReadLine());

            float[ , ] arrayX = new float[dhoriz, vhoriz];

            for(i=0; i<vhoriz; i++){

                for(j=0; j<dhoriz; j++){
                    Console.Write($"Insira Linha {i} e coluna {j}->");
                    arrayX[i, j] = float.Parse(Console.ReadLine());
                }
            }

            //print array
            for(i=0; i<vhoriz; i++){
                for(j=0; j<dhoriz; j++){
                    Console.Write($"{arrayX[i, j]} | ");
                }
                Console.WriteLine();
            }


        }
    }
}
