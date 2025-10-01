using System;

Console.WriteLine("Ingrese el nombre de un corredor: ");
string nombre = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Ingrese los tres tiempos de sus carreras (enteros): ");
int[] tiempos = new int[3];
for (int i = 0; i < 3; i++)
{
    while (true)
    {
        Console.Write($"Tiempo {i + 1}: ");
        string? entrada = Console.ReadLine();
        if (int.TryParse(entrada, out int valor))
        {
            tiempos[i] = valor;
            break;
        }
        Console.WriteLine("Entrada no válida. Introduzca un número entero (por ejemplo 12).");
    }
}

double promedio = CalcularPromedio(tiempos);
Console.WriteLine($"El promedio de los tiempos de {nombre} es: {promedio}");

// Función que calcula el promedio a partir de tres enteros
static double CalcularPromedio(int[] tiempos)
{
    if (tiempos == null || tiempos.Length == 0) return 0;
    long suma = 0;
    foreach (int v in tiempos) suma += v;
    return (double)suma / tiempos.Length;
}