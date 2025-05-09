namespace GenericRepositoryDemo;

public class GenericRepository<T> : IRepository<T> where T : class, IEntity
{
    private readonly List<T> _store = new List<T>();
    private int _nextId = 1;

    public void Add(T item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));
        if (item.Id == 0)
            item.Id = _nextId++;
        _store.Add(item);
    }

    public void Remove(T item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));
        _store.Remove(item);
    }

    public void Save()
    {
        
    }

    public IEnumerable<T> GetAll()
    {
        return _store.ToList();
    }

    public T GetById(int id)
    {
        return _store.FirstOrDefault(e => e.Id == id);
    }
}