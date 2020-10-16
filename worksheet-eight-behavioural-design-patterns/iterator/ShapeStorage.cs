namespace iterator
{ 
    public class ShapeStorage<T> where T : Shape, new()
    {
        private const int NumberOfShapes = 5;
        private readonly T[] _shapes = new T[NumberOfShapes];
        private int _index = 0;

        public void AddShape(string name) =>
            _shapes[_index++] = new T {Id = _index, Name = name};
        

        // public T[] GetShapes() => _shapes;
        // Additional methods?
        public int Count => _shapes.Length;
        public T this[int i]
        {
            get => _shapes[i];
            set => _shapes[i] = value;
        }

        // Indexer?
    }
}