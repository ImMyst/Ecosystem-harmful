namespace TP_Nuisible
{
    public interface IEcosystem
    {
        Ecosystem Create(uint xMax, uint yMax, uint nHarmful);
    }
}