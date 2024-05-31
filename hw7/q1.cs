public class MyStack<T>
{
    private List<T> _elements = new List<T>();

    public int Count()
    {
        return _elements.Count;
    }

    public T Pop()
    {
        if (_elements.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        T item = _elements[_elements.Count - 1];
        _elements.RemoveAt(_elements.Count - 1);
        return item;
    }

    public void Push(T item)
    {
        _elements.Add(item);
    }
}
