namespace TP_Nuisible
{
    public class Zombie : Harmful
    {
        public static readonly new uint _speed = 1;
        public Zombie(uint X, uint Y) : base("Zombie", X, Y, _speed, Harmful.state.Zombie)
        {
            
        }
    }
}