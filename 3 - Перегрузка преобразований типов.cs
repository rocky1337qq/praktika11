using System;

class Temperature
{
    public double Celsius { get; }

    public Temperature(double celsius)
    {
        Celsius = celsius;
    }

    public double Fahrenheit
    {
        get
        {
            return Celsius * 9 / 5 + 32;
        }
    }

    public double Kelvin
    {
        get
        {
            return Celsius + 273.15;
        }
    }

    public override string ToString()
    {
        return $"{Celsius:F2} °C";
    }

    public static implicit operator Temperature(double celsius)
    {
        return new Temperature(celsius);
    }

    public static explicit operator double(Temperature temp)
    {
        return temp.Celsius;
    }

    public static explicit operator string(Temperature temp)
    {
        return temp.ToString();
    }

    public static explicit operator Temperature(string str)
    {
        string cleanStr = str.Replace(" °C", "").Trim();
        double celsius = Convert.ToDouble(cleanStr);
        return new Temperature(celsius);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Temperature t1 = new Temperature(25.5);
        Console.WriteLine($"Температура: {t1}");
        Console.WriteLine($"В Фаренгейтах: {t1.Fahrenheit}");

        Temperature t2 = 30.0;
        Console.WriteLine($"Неявное double -> Temperature: {t2}");

        double c = (double)t1;
        Console.WriteLine($"Явное Temperature -> double: {c}");

        string s = (string)t1;
        Console.WriteLine($"Явное Temperature -> string: {s}");

        Temperature t3 = (Temperature)"40,5 °C";
        Console.WriteLine($"Явное string -> Temperature: {t3}");

        Console.ReadLine();
    }
}