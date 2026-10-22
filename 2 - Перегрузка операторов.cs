using System;

class Vector2D
{
    public double X { get; }
    public double Y { get; }

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double Length
    {
        get
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }

    public override string ToString()
    {
        return $"({X}; {Y})";
    }

    public static Vector2D operator +(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X + b.X, a.Y + b.Y);
    }

    public static Vector2D operator -(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X - b.X, a.Y - b.Y);
    }

    public static Vector2D operator *(Vector2D v, double k)
    {
        return new Vector2D(v.X * k, v.Y * k);
    }

    public static Vector2D operator *(double k, Vector2D v)
    {
        return new Vector2D(v.X * k, v.Y * k);
    }

    public static double operator *(Vector2D a, Vector2D b)
    {
        return a.X * b.X + a.Y * b.Y;
    }

    public static Vector2D operator -(Vector2D v)
    {
        return new Vector2D(-v.X, -v.Y);
    }

    public static Vector2D operator ++(Vector2D v)
    {
        return new Vector2D(v.X + 1, v.Y + 1);
    }

    public static Vector2D operator --(Vector2D v)
    {
        return new Vector2D(v.X - 1, v.Y - 1);
    }

    public static bool operator ==(Vector2D a, Vector2D b)
    {
        return a.X == b.X && a.Y == b.Y;
    }

    public static bool operator !=(Vector2D a, Vector2D b)
    {
        return !(a == b);
    }

    public static bool operator <(Vector2D a, Vector2D b)
    {
        return a.Length < b.Length;
    }

    public static bool operator >(Vector2D a, Vector2D b)
    {
        return a.Length > b.Length;
    }

    public static bool operator <=(Vector2D a, Vector2D b)
    {
        return a.Length <= b.Length;
    }

    public static bool operator >=(Vector2D a, Vector2D b)
    {
        return a.Length >= b.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vector2D v1 = new Vector2D(3, 4);
        Vector2D v2 = new Vector2D(1, 2);

        Console.WriteLine($"Векторы: v1 = {v1}, v2 = {v2}");

        Vector2D sum = v1 + v2;
        Console.WriteLine($"Сложение: {sum}");

        double scalar = v1 * v2;
        Console.WriteLine($"Скалярное произведение: {scalar}");

        Vector2D mult = v1 * 2;
        Console.WriteLine($"Умножение на число: {mult}");

        bool isGreater = v1 > v2;
        Console.WriteLine($"Сравнение (v1 > v2): {isGreater}");

        Console.ReadLine();
    }
}