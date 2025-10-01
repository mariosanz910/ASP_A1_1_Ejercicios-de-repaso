Console.WriteLine("Calculadora de aprobados y suspensos:    ");
Console.Write("Ingrese la nota:   ");
double nota = double.Parse(Console.ReadLine());
if (nota >= 0 && nota <= 10)
{
    if (nota >= 5)
    {
        Console.WriteLine("Aprobado");
    }
    else
    {
        Console.WriteLine("Suspenso");
    }
}
else
{
    Console.WriteLine("Nota no válida, debe estar entre 0 y 10.");
}