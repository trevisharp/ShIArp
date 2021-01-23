namespace ShIArp
{
    public interface TreeAlgorithm<T>
        where T : struct
    {
        double Avaliate(T[] children);
        T Choose(T[] children);
        bool Expand(T state, int depth);
    }
}