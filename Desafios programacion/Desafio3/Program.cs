using System;

namespace SumaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce el primer valor:");
                string valor1Str = Console.ReadLine();
                int valor1 = Convert.ToInt32(valor1Str);

                Console.WriteLine("Introduce el segundo valor:");
                string valor2Str = Console.ReadLine();
                int valor2 = Convert.ToInt32(valor2Str);

                int suma = SumarValores(valor1, valor2);
                Console.WriteLine($"La suma de {valor1} y {valor2} es: {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debes introducir valores numéricos.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Los valores introducidos están fuera del rango permitido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Fin del programa.");
            }
        }

        static int SumarValores(int a, int b)
        {
            return a + b;
        }
    }
}
