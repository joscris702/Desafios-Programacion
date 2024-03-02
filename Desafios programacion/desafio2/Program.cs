using System;

class CalculadoraBasica
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public int Restar(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public int Dividir(int a, int b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;
        }
    }

    static void Main()
    {
        CalculadoraBasica calculadora = new CalculadoraBasica();

        int num1 = 10;
        int num2 = 5;

        Console.WriteLine($"Suma: {num1} + {num2} = {calculadora.Sumar(num1, num2)}");
        Console.WriteLine($"Resta: {num1} - {num2} = {calculadora.Restar(num1, num2)}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {calculadora.Multiplicar(num1, num2)}");
        Console.WriteLine($"División: {num1} / {num2} = {calculadora.Dividir(num1, num2)}");
    }
}
