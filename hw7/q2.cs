public class MyList<T>
{
    private List<T> _elements2 = new List<T>();

    public void Add(T element)
    {
        _elements2.Add(element);
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= _elements2.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        T item = _elements2[index];
        _elements2.RemoveAt(index);
        return item;
    }

    public bool Contains(T element)
    {
        return _elements2.Contains(element);
    }

    public void Clear()
    {
        _elements2.Clear();
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > _elements2.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        _elements2.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index >= _elements2.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        _elements2.RemoveAt(index);
    }

    public T Find(int index)
    {
        if (index < 0 || index >= _elements2.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        return _elements2[index];
    }
}
