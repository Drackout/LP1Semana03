using System;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!

            //TRAP equip equip
            TrapType trap = Enum.Parse<TrapType>(args[0]);

            //Console.WriteLine(args[0]);
            PlayerGear gear = ParseGear(args);

            bool survives = CanSurviveTrap(trap, gear);

            DisplayResult(trap, survives);

            // DO NOT CHANGE THIS METHOD!
        }


        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {
            PlayerGear gear = 0;

            foreach (var txt in args)
            {
                if (txt == "Helmet")
                    gear |= PlayerGear.Helmet;
                if (txt == "Shield")
                    gear |= PlayerGear.Shield;
                if (txt == "Boots")
                    gear |= PlayerGear.Boots;
            }
            //Console.WriteLine(gear);
            return gear;
        }


        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {
            bool survive;
            if ((trap == TrapType.PoisonGas) && 
            (gear & PlayerGear.Shield) == PlayerGear.Shield && 
            (gear & PlayerGear.Helmet) == PlayerGear.Helmet)
            {
                survive = true;
            }
            else if ((trap == TrapType.FallingRocks) && 
            (gear & PlayerGear.Helmet) == PlayerGear.Helmet)
            {
                survive = true;
            }
            else if ((trap == TrapType.SpinningBlades) && 
            (gear & PlayerGear.Shield) == PlayerGear.Shield)
            {
                survive = true;
            }
            else if ((trap == TrapType.LavaPit) && 
            (gear & PlayerGear.Boots) == PlayerGear.Boots)
            {
                survive = true;
            }
            else
                survive = false;

            return survive;
        }


        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap, bool survives)
        {
            if (survives)
            {
                Console.WriteLine("Player survives " + trap);
            }
            else
            {
                Console.WriteLine("Player dies due to " + trap);
            }
        }
    }
}
