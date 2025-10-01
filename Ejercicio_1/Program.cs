Console.Write("Digite un número:    ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine($"El número ingresado es: {numero}");
Console.WriteLine("Digite otro número:   ");
int numero2 = int.Parse(Console.ReadLine());
Console.WriteLine($"El número ingresado es: {numero2}");
Console.WriteLine($"El resultado de la suma es: {numero + numero2}");
Console.WriteLine($"El resultado de la resta es: {numero - numero2}");
Console.WriteLine($"El resultado de la multiplicación es: {numero * numero2}");
if (numero2 != 0)
{
    Console.WriteLine($"El resultado de la división es: {numero / numero2}");
}
else
{
    Console.WriteLine("No se puede dividir por cero.");
}
