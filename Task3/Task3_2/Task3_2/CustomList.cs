using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class CustomList<T> : IList<T>, ICollection<T>, IEnumerable<T>
    {
        private T[] _source;
        private int _startCapacity = 8;

        public CustomList()
        {
            _source = new T[_startCapacity];
        }

        public CustomList(int capacity)
        {
            _source = new T[capacity];
        }

        public CustomList(IEnumerable<T> collection)
        {
            _source = new T[collection.Count()];

            foreach (T item in collection)
                this.Add(item);
        }

        public T this[int index] 
        { 
            get 
            {
                if (index > Count || Count + index < 0)
                    throw new ArgumentOutOfRangeException("index must be less than Count if index positive and more than -Count if negative");
                if (index < 0)
                    return _source[Count + index];

                return _source[index];
            }
            set
            {
                if (index > Count || Count + index < 0)
                    throw new ArgumentOutOfRangeException("index must be less than Count if index positive and more than -Count if negative");
                if (value == null) throw new ArgumentNullException("value can't be null");
                if (index < 0)
                    _source[Count + index]  = value;

                _source[index] = value;
            }
        }

        public int Count 
        { 
            get;
            private set;
        }

        public int Capacity => _source.Length;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (item == null) throw new ArgumentNullException("item can't be null");

            if (Count == Capacity)
            {
                T[] newSource = new T[_source.Length * 2];
                for(int i = 0; i < _source.Length; i++)
                {
                    newSource[i] = _source[i];
                }

                _source = newSource;
            }

            _source[Count] = item;
            Count++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            if((Count + collection.Count()) <= Capacity)
            {
                foreach (T item in collection)
                    this.Add(item);

                return;
            }

            CustomList<T> newCList = new CustomList<T>(Count + collection.Count());
            int index = 0;
            while(index < Count)
            {
                newCList.Add(_source[index]);
                index++;
            }

            foreach (T item in collection)
                newCList.Add(item);

            _source = newCList._source;
            Count = newCList.Count;
        }

        public void Clear()
        {
            int oldCapacity = Capacity;
            _source = new T[oldCapacity];
            Count = 0;
        }

        public bool Contains(T item)
        {
            return _source.Contains<T>(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array.Length - arrayIndex < Count) 
                throw new ArgumentOutOfRangeException("the length - arrayIndex of an array must be more than Collection Count");

            for (int i = 0; i < Count; i++)
                array[arrayIndex + i] = _source[i];
        }

        public IEnumerator<T> GetEnumerator() => new Enumerator(_source, Count);

        public int IndexOf(T item)
        {
            int index = -1;

            for(int i = 0; i < Count; i++)
            {
                if (_source[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void Insert(int index, T item)
        {
            if (index > Count || index < 0)
                throw new ArgumentOutOfRangeException("index must be more or equals 0 and less or equals Count");
            if (item == null) throw new ArgumentNullException("item can't be null");

            if (index == Count)
                Add(item);
            else
            {
                CustomList<T> newCList = new CustomList<T>(Capacity);
                for (int i = 0; i < Count; i++)
                {
                    if(i == index)
                        newCList.Add(item);
                    newCList.Add(this[i]);                   
                }

                this._source = newCList._source;
                this.Count = newCList.Count;
            }
        }

        public bool Remove(T item)
        {
            int index = -1;
            if ((index = IndexOf(item)) < 0) return false;

            RemoveAt(index);
            return true;
        }

        public void RemoveAt(int index)
        {
            if (index > Count && index < 0)
                throw new ArgumentOutOfRangeException("index must be more or equals 0 and less or equals Count");
            CustomList<T> newCList = new CustomList<T>(Capacity);

            for (int i = 0; i < Count; i++)
            {
                if (i == index)
                    continue;

                newCList.Add(this[i]);
            }

            this._source = newCList._source;
            this.Count = newCList.Count;
        }

        public T[] ToArray()
        {
            T[] gettableArr = new T[Count];

            for (int i = 0; i < Count; i++)
                gettableArr[i] = _source[i];

            return gettableArr;
        }

        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_source, Count);

        public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
        {
            private T[] _items;       
            private int _position;

            public int count;
            public Enumerator(T[] items, int count)
            {
                this._items = items;
                _position = -1;
                this.count = count;
            }                

            public T Current 
            {
                get
                {
                    if (_position == -1 || _position >= _items.Length)
                        throw new ArgumentOutOfRangeException();
                    return _items[_position];
                }
            }

            object IEnumerator.Current
            {
                get
                {                   
                    return Current;
                }
            }

            public bool MoveNext()
            {
                if (_position >= count - 1)
                    return false;

                _position++;
                return true;
            }

            public void Reset() => _position = -1;

            public void Dispose()
            {
                //TODO
            }
        }
    }
}
