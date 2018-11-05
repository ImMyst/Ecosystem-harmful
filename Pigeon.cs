namespace TP_Nuisible
{
    public class Pigeon : Harmful
    {
        public static readonly new uint _speed = 3;
        public Pigeon(uint X, uint Y) : base(X, Y, _speed, Harmful.state.Alive)
        {

        }
    }
}