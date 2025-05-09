namespace Color_Ball;

public class Color
{
    private int _red, _green, _blue, _alpha;

    public Color(int red, int green, int blue, int alpha)
    {
        SetRed(red);
        SetGreen(green);
        SetBlue(blue);
        SetAlpha(alpha);
    }

    public Color(int red, int green, int blue)
        : this(red, green, blue, 255) { }

    public int GetRed()    => _red;
    public void SetRed(int r)
    {
        if (r < 0 || r > 255) throw new ArgumentOutOfRangeException(nameof(r));
        _red = r;
    }

    public int GetGreen()  => _green;
    public void SetGreen(int g)
    {
        if (g < 0 || g > 255) throw new ArgumentOutOfRangeException(nameof(g));
        _green = g;
    }

    public int GetBlue()   => _blue;
    public void SetBlue(int b)
    {
        if (b < 0 || b > 255) throw new ArgumentOutOfRangeException(nameof(b));
        _blue = b;
    }

    public int GetAlpha()  => _alpha;
    public void SetAlpha(int a)
    {
        if (a < 0 || a > 255) throw new ArgumentOutOfRangeException(nameof(a));
        _alpha = a;
    }

    public int GetGrayscale() => (_red + _green + _blue) / 3;

    public override string ToString()
        => $"(R={_red},G={_green},B={_blue},A={_alpha})";
}