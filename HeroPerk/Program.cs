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
                    run=false;
                    break;
                }
            // Console.WriteLine("USER PERK --->" + userPerks);
            }

            if(userPerks == 0)
            {
                Console.WriteLine("!No perks at all!");
            }
            if (run && userPerks != 0)
                Console.WriteLine(userPerks);

            if ((userPerks & Perks.Stealth) == Perks.Stealth & 
                (userPerks & Perks.DoubleJump) == Perks.DoubleJump)
            {
                Console.WriteLine("!Silent jumper!");
            }
            if ((userPerks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("!Not gonna make it!");
            }
            
            
            
        }
    }
}
