namespace TP_Nuisible
{
    public class Rat : Harmful
    {
        public static readonly new uint _speed = 2;
        public Rat(uint X, uint Y) : base(X, Y, _speed, Harmful.state.Rat)
        {

        }
    }
}