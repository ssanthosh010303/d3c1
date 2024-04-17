/*
 * Author: Sakthi (Sandy) Santhosh
 * Created on: 11/04/2024
 *
 * Day-3 Challenge-1: Build a Calculator
 */
namespace Challenge1;

class DumbCalculator
{
    private int _num1, _num2;

    public DumbCalculator(int userNum1, int userNum2)
    {
        _num1 = userNum1;
        _num2 = userNum2;
    }

    public int Add() { return _num1 + _num2; }

    public int Subtract(bool reverse = false)
    {
        return (reverse) ? (_num2 - _num1) : (_num1 - _num2);
    }

    public int Multiply() { return _num1 * _num2; }

    public float Divide()
    {
        if (_num2 == 0) throw new DivideByZeroException("Cannot divide by zero.");

        return _num1 / (float) _num2;
    }

    public int Modulo()
    {
        if (_num2 == 0) throw new DivideByZeroException("Cannot divide by zero.");

        return _num1 % _num2;
    }
}

class Program
{
    static void Main()
    {
        int num1 = 10, num2 = 10;
        DumbCalculator calculatorHandle = new(num1, num2);

        try
        {
            checked
            {
                Console.WriteLine("Results");
                Console.WriteLine("  Sum:        " + calculatorHandle.Add());
                Console.WriteLine("  Difference: "
                    + calculatorHandle.Subtract()
                    + ' '
                    + calculatorHandle.Subtract(reverse: true));
                Console.WriteLine("  Product:    " + calculatorHandle.Multiply());
                Console.WriteLine("  Quotient:   " + calculatorHandle.Divide());
                Console.WriteLine("  Reminder:   " + calculatorHandle.Modulo());
            }
        }
        catch (DivideByZeroException exception)
        {
            Console.WriteLine("Error: " + exception.Message);
        }
        catch (OverflowException exception)
        {
            Console.WriteLine("Error: " + exception.Message);
        }
    }
}
