namespace Color_Ball;
public class Ball
{
    private double _size;
    private readonly Color _color;
    private int _throwCount;

    public Ball(double size, Color color)
    {
        if (size < 0) throw new ArgumentOutOfRangeException(nameof(size));
        _size = size;
        _color = color ?? throw new ArgumentNullException(nameof(color));
    }
    
    public Ball(Color color) : this(1.0, color) { }

    public double GetSize()      => _size;
    public Color  GetColor()     => _color;
    public int    GetThrowCount()=> _throwCount;

    public void Pop()            => _size = 0;

    public void Throw()
    {
        if (_size > 0)
            _throwCount++;
    }

    public override string ToString()
        => $"Ball(Size={_size}, Color={_color}, Thrown={_throwCount})";
}

