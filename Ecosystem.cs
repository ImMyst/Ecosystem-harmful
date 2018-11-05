using System;
using System.Collections.Generic;

namespace TP_Nuisible
{
    public class Ecosystem
    {
        private uint _XMax;
        private uint _YMax;
        private List<Harmful> _ListHarmful;
        public Ecosystem(uint _XMax, uint _YMax, List<Harmful> _ListHarmful)
        {
            this._XMax = _XMax;
            this._YMax = _YMax;
            this._ListHarmful = _ListHarmful;
        }

        public bool IsHarmfulDead()
        {
            foreach (var OneHarmful in _ListHarmful)
            {
                if (OneHarmful.IsDead())
                {
                    return true;
                }
            }
            return false;
        }

        public void Simulation()
        {
            foreach (var OneHarmful in _ListHarmful)
            {
                OneHarmful.Movements(_XMax, _YMax);
            }

            foreach (var FirstHarmful in _ListHarmful)
            {
                foreach (var SecondHarmful in _ListHarmful)
                {
                    if (FirstHarmful.IsSameCase(SecondHarmful) && FirstHarmful != SecondHarmful)
                    {
                        FirstHarmful.Collision(SecondHarmful);
                    }
                }
            }
            foreach (var OneHarmful in _ListHarmful)
            {
                OneHarmful.startSimulation();
            }
        }
    }
}