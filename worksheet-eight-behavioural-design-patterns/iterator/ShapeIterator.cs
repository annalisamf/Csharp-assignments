using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace iterator
{
    public class ShapeIterator<TShape> : IEnumerator<TShape>
    {
        private TShape[] Shapes { get; set; }

        private int _index;

// private bool reverse = false;

        public ShapeIterator(TShape thing)
        {
            Shapes = new[] {thing};
            _index = 0;
        }

        public bool MoveNext()
        {
            _index++;
            return _index < Shapes.Length && Shapes[_index] != null;
        }

        public void Reset()
        {
            _index = 0;
        }

        public TShape Current => Shapes[_index];

        object? IEnumerator.Current => Current as Shape;

        public void Dispose()
        {
            if (_index <= 0)
                throw new IndexOutOfRangeException("invalid index");
            if (Shapes[_index - 1] != null)
            {
                for (var i = _index - 1; i < Shapes.Length - 1; i++)
                {
                    Shapes[i] = Shapes[i + 1];
                }
            }

            Shapes[^1] = default(TShape);
        }
    }
}