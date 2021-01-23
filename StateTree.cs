namespace ShIArp
{
    public class StateTree<T>
        where T : struct
    {
        private Node<T> root;

        public TreeAlgorithm<T> Algorithm { get; set; }
        public StateManager<T> Manager { get; set; }
        public T RootState => root.State;

        public StateTree(TreeAlgorithm<T> algorithm, StateManager<T> manager, T root)
        {
            this.Algorithm = algorithm;
            this.Manager = manager;

            var node = new Node();
            node.State = root;
            node.Avaliation = manager.Avaliation(root);
            this.root = node;
        }

        

    }

    internal struct Node<T>
        where T : struct
    {
        internal T State;
        internal double Avaliation;
        internal T[] Children;
    }
}