namespace MyStackClass;

public class MyStack<T>
{
    private List<T> items = new List<T>();
    
    int Count()
    {
        return items.Count;
    }

    T Pop()
    {
        int i = items.Count - 1;
        T item = items[i];
        items.RemoveAt(i);
        return item;
    }

    void Push(T item)
    {
        items.Add(item);
    }
}