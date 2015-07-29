using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericCollection
{
    public class MyCollection<T> : ICollection<T>
    {
        private List<T> list = new List<T>();
        private SortedList<T, T> sortedList = new SortedList<T, T>();

        public void Add(T item)
        {
            if (list.Count < 5)
            {
                list.Add(item);
            }
            else
            {
                sortedList = new SortedList<T, T>(list.ToDictionary(s => s)) {{item, item}};
            }
        }
        public void Clear()
        {
            list.Clear();
            sortedList.Clear();
        }

        public bool Contains(T item)
        {
            var result = list.Contains(item) || sortedList.ContainsValue(item);
            return result;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (list.Count <= 5)
            {
                for (var i = 0; i < list.Count; i++)
                {
                    array[i] = list[i];
                }
            }
            else
            {
                for (var i = 0; i < sortedList.Count; i++)
                {
                    array[i] = sortedList.Values[i];
                }
            }
        }

        public int Count
        {
            get { return list.Count + sortedList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            var result = false;
            if (list.Count <= 5)
            {
                list.Remove(item);
                result = true;
            }
            else
            {
                sortedList.Remove(item);
                result = true;
            }
            return result;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator<T>(this);
        }
    }
    public class MyEnumerator<T> : IEnumerator<T>
    {
        private MyCollection<T> _collection;
        private int curIndex;


        public MyEnumerator(MyCollection<T> collection)
        {
            _collection = collection;
            curIndex = -1;
            Current = default(T);

        }

        public bool MoveNext()
        {
            if (++curIndex >= _collection.Count)
            {
                return false;
            }
            else
            {
                //only for foreach loop but do not need
                //curItem = _collection[curIndex];
            }
            return true;
        }

        public void Reset() { curIndex = -1; }

        void IDisposable.Dispose() { }

        public T Current { get; private set; }


        object IEnumerator.Current
        {
            get { return Current; }
        }

    }
}
