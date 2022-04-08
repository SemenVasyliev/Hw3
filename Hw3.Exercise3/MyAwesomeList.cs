namespace Hw3.Exercise3
{
    public class MyAwesomeList<T>
    {

        public int Count { get; set; }

        private T[] _items = Array.Empty<T>();


        public MyAwesomeList(int capacity = 1)
        {
            Count = capacity;
        }
        public T GetByIndex(int index)
        {
            return _items[index];
        }

        public void DeleteByIndex(int index)
        {
            var itemsTemp = new T[_items.Length - 1];
            var j = 0;
            for (int i = 0; i < _items.Length; i++)
            {
                if (i != index)
                {
                    itemsTemp[j] = _items[i];
                    j++;
                }
            }
            _items = itemsTemp;
            Count = _items.Length;
        }

        public bool DeleteAllElements()
        {
            Count = 0;
            _items = new T[Count];
            return true;
        }

        public void Add(T element)
        {
            _items = _items.Concat(new T[] { element }).ToArray();
            Count = _items.Length;
        }

        public void InsertAt(T element, int index)
        {
            _items[index] = element;
        }

        public bool Contains(T value)
        {
            return _items.Contains(value);
        }
    }
}
