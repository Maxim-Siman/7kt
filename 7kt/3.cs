using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }
    public static double Subtract(double a, double b)
    {
        return a - b;
    }
    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    public static double Divide(double a, double b)
    {
        return a / b;
    }

    static void Main(string[] args)
    {
        Func<double, double, double> add = Add;
        Func<double, double, double> subtract = Subtract;
        Func<double, double, double> multiply = Multiply;
        Func<double, double, double> divide = Divide;

        double result = add(2.2, 3.2);
        Console.WriteLine(result);
        double result2 = subtract(2.2, 3.2);
        Console.WriteLine(result2);
        double result3 = multiply(2.2, 3.2);
        Console.WriteLine(result3);
        double result4 = divide(2.2, 3.2);
        Console.WriteLine(result4);
    }
}
