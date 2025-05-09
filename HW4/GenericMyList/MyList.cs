namespace GenericMyList;

using System;
using System.Collections.Generic;

public class MyList<T>
{
    private T[] _items;
    private int _count;
    private const int _defaultCapacity = 4;

    public MyList()
    {
        _items = new T[_defaultCapacity];
        _count = 0;
    }
    
    public int Count => _count;
    
    public void Add(T element)
    {
        EnsureCapacity(_count + 1);
        _items[_count++] = element;
    }
    
    public T Remove(int index)
    {
        CheckIndex(index);
        T removed = _items[index];
        Array.Copy(_items, index + 1, _items, index, _count - index - 1);
        _items[--_count] = default!;
        return removed;
    }

    public bool Contains(T element)
    {
        var comparer = EqualityComparer<T>.Default;
        for (int i = 0; i < _count; i++)
            if (comparer.Equals(_items[i], element))
                return true;
        return false;
    }
    
    public void Clear()
    {
        Array.Clear(_items, 0, _count);
        _count = 0;
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > _count)
            throw new ArgumentOutOfRangeException(nameof(index));
        EnsureCapacity(_count + 1);
        Array.Copy(_items, index, _items, index + 1, _count - index);
        _items[index] = element;
        _count++;
    }
    
    public void DeleteAt(int index)
    {
        Remove(index);
    }
    
    public T Find(int index)
    {
        CheckIndex(index);
        return _items[index];
    }

    private void EnsureCapacity(int min)
    {
        if (min <= _items.Length) return;
        int newCap = _items.Length * 2;
        if (newCap < min) newCap = min;
        Array.Resize(ref _items, newCap);
    }

    private void CheckIndex(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException(nameof(index));
    }
}
