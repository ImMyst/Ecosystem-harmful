using System.Collections.Generic;

namespace TP_Nuisible
{
    public class Ecosystem
    {
        private uint _XMax;
        private uint _YMax;
        private List<Harmful> _ListHarmful;
        public Ecosystem(uint _XMax, uint _YMax, List<Harmful> ListHarmful)
        {
            this._XMax = _XMax;
            this._YMax = _YMax;
            this._ListHarmful = ListHarmful;
        }

        public bool IsHarmfulDead()
        {
            foreach (var OneHarmful in _ListHarmful)
            {
                if (OneHarmful.IsDead())
                {
                    return false;
                }
            }
            return true;
        }

        public void Simulate()
        {
            foreach (var OneHarmful in _ListHarmful)
            {
                OneHarmful.Movements(_XMax, _YMax);
            }

            foreach (var OneHarmful in _ListHarmful)
            {
                foreach (var SecondHarmful in _ListHarmful)
                {
                    if (OneHarmful.IsSameCase(SecondHarmful) && OneHarmful != SecondHarmful)
                    {
                        OneHarmful.Collision(SecondHarmful);
                    }
                }
            }
            
            foreach (var OneHarmful in _ListHarmful)
            {
                OneHarmful.showSpecs();
            }
        }
    }
}