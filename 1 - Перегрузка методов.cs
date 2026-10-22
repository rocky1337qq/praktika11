using System;

class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction()
    {
        _numerator = 0;
        _denominator = 1;
    }

    public Fraction Add(Fraction other)
    {
        int newNum = this._numerator * other._denominator + other._numerator * this._denominator;
        int newDen = this._denominator * other._denominator;
        return new Fraction(newNum, newDen);
    }

    public Fraction Add(int number)
    {
        int newNum = this._numerator + number * this._denominator;
        int newDen = this._denominator;
        return new Fraction(newNum, newDen);
    }

    public Fraction Add(double number)
    {
        int tempNum = Convert.ToInt32(number * 100);
        int tempDen = 100;
        int newNum = this._numerator * tempDen + tempNum * this._denominator;
        int newDen = this._denominator * tempDen;
        return new Fraction(newNum, newDen);
    }

    public static Fraction Add(Fraction a, Fraction b)
    {
        int newNum = a._numerator * b._denominator + b._numerator * a._denominator;
        int newDen = a._denominator * b._denominator;
        return new Fraction(newNum, newDen);
    }

    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(1, 3);

        Console.WriteLine($"Первая дробь: {f1}");
        Console.WriteLine($"Вторая дробь: {f2}");

        Fraction res1 = f1.Add(f2);
        Console.WriteLine($"Сложение дробей (метод): {f1} + {f2} = {res1}");

        Fraction res2 = f1.Add(2);
        Console.WriteLine($"Сложение с int: {f1} + 2 = {res2}");

        Fraction res3 = f1.Add(1.5);
        Console.WriteLine($"Сложение с double: {f1} + 1.5 = {res3}");

        Fraction res4 = Fraction.Add(f1, f2);
        Console.WriteLine($"Сложение (static): {f1} + {f2} = {res4}");

        Console.ReadLine();
    }
}