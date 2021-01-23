namespace ShIArp
{
    public interface StateManager<T>
        where T : struct
    {
        T[] Next(T current);
        double Avaliation(T state);
        T Empty { get; }
    }
}