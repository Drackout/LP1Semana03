using System;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Perks userPerks = 0;
            string comms = args[0];
            char cha;
            bool run = true;

            for (int i = 0; i < comms.Length; i++)
            { 
                cha = comms[i];

                if (cha == 'w')
                    userPerks ^= Perks.WarpShift;
                else if (cha == 'a')
                    userPerks ^= Perks.AutoHeal;
                else if (cha == 's')
                    userPerks ^= Perks.Stealth;
                else if (cha == 'd')
                    userPerks ^= Perks.DoubleJump;
                else
                {
                    Console.WriteLine("!Unknown perk!");
                    run = false;
                    break;
                }
            // Console.WriteLine("USER PERK --->" + userPerks);
            }

            if(userPerks == 0)
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");   
            }

            if (userPerks.ToString().Contains(Perks.Stealth.ToString()) &&
            userPerks.ToString().Contains(Perks.DoubleJump.ToString()) 
            && run==true) 
            {
                Console.WriteLine(userPerks);
                Console.WriteLine("!Silent jumper!");
            }
            
            if (!userPerks.ToString().Contains(Perks.AutoHeal.ToString()) 
            && run==true && userPerks != 0)
            {
                Console.WriteLine(userPerks);
                Console.WriteLine("!Not gonna make it!");   
            }    

            // Mega confusão.. com as coisas da aula nao funciona
            // Percebi a materia dos 0001 0010 etc etc.. 
            // Nao consigo replicar de jeito nenhum.. não faz sentido
            // Exercicio feito apenas com remendos
            // ??????????


            //if (userPerks == Perks.Stealth & userPerks == Perks.DoubleJump)
            //        Console.WriteLine("!Silent jumper!");
            //if (userPerks == Perks.AutoHeal)
            //        Console.WriteLine("!Not gonna make it!");
        }
    }
}
