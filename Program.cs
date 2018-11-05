using System;

namespace TP_Nuisible
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RandomEcosystem randomEcosystem = new RandomEcosystem();
            Ecosystem ecosystem = randomEcosystem.Create(10, 10, 5);

            while (ecosystem.IsHarmfulDead())
            {
                ecosystem.Simulate();
                Console.WriteLine("\n*****************************************************************************\n");
            }
        }
    }
}
