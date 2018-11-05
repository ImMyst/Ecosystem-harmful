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
        
        public bool IsHarmfulAlive()        // Test si un nuisible est vivant et return true ou false
        {
            foreach (var OneHarmful in _ListHarmful)
            {
                if (OneHarmful.IsAlive())
                {
                    return true;
                }
            }
            return false;
        }

        public void Simulate()      // Simule les mouvements et les collisions des nuisibles
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
            
            foreach (var OneHarmful in _ListHarmful) // Affiche les résltats pour tous les nuisibles
            {
                OneHarmful.showResults();
            }
        }
    }
}