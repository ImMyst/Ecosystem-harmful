using System;
using System.Collections.Generic;

namespace TP_Nuisible
{
    public sealed class RandomEcosystem : IEcosystem
    {
        public Ecosystem Create(uint XMax, uint YMax, uint nHarmful)    // Random nuisibles
        {
            var Harmfuls = new List<Harmful>();

            Random random = new Random();
            
            for (uint i = 0; i < nHarmful; i++)
            {
                uint X = (uint)random.Next(0, (int)XMax);
                uint Y = (uint)random.Next(0, (int)YMax);
                
                switch (random.Next(0, 3))
                {
                    case 0:
                        Harmfuls.Add(new Pigeon(X,Y));
                        break;
                    case 1:
                        Harmfuls.Add(new Rat(X,Y));
                        break;
                    case 2:
                        Harmfuls.Add(new Zombie(X,Y));
                        break;
                }
            }
            
            return new Ecosystem(XMax, YMax, Harmfuls);
        }
    }
}