using System;
using System.Collections.Generic;

namespace TP_Nuisible
{
    public sealed class RandomEcosystem : IEcosystem
    {
        public Ecosystem Create(uint XMax, uint YMax, uint nHarmful)
        {
            var harmfuls = new List<Harmful>();

            Random random = new Random();
            
            for (uint i = 0; i < nHarmful; i++)
            {
                uint X = (uint)random.Next(0, (int)XMax);
                uint Y = (uint)random.Next(0, (int)YMax);
                
                switch (random.Next(0, 3))
                {
                    case 0:
                        harmfuls.Add(new Pigeon(X,Y));
                        break;
                    case 1:
                        harmfuls.Add(new Rat(X,Y));
                        break;
                    case 2:
                        harmfuls.Add(new Zombie(X,Y));
                        break;
                }
            }
            
            return new Ecosystem(XMax, YMax, harmfuls);
        }
    }
}