using System;

namespace TP_Nuisible
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RandomEcosystem randomEcosystem = new RandomEcosystem();
            Ecosystem ecosystem = randomEcosystem.Create(10, 10, 15);

            while (ecosystem.IsHarmfulAlive())
            {
                ecosystem.Simulate();
                Console.WriteLine("\n*****************************************************************************\n");
            }
        }
    }
}
