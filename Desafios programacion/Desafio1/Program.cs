using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingresa tu nombre, porfavor: ");
        string nombreUsuario = Console.ReadLine();

        int[] ingresos = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingresa el ingreso del mes {i + 1}: ");
            ingresos[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sumaIngresos = SumaIngresos(ingresos);

        decimal promedioIngresos = PromedioIngresos(ingresos);

        Console.WriteLine($"Hola {nombreUsuario}, en total ganaste {sumaIngresos} y promediaste {promedioIngresos:C}.");

        Console.ReadKey();
    }
    public static int SumaIngresos(params int[] ingresos)
    {
        int suma = 0;
        foreach (int ingreso in ingresos)
        {
            suma += ingreso;
        }
        return suma;
    }

    public static decimal PromedioIngresos(params int[] ingresos)
    {
        int suma = SumaIngresos(ingresos);
        decimal promedio = (decimal)suma / ingresos.Length;
        return promedio;
    }
}

