using System;

class Program
{
    static void Main(string[] args)
    {
        // Array de precios de productos
        double[] productos = { 1.20, 0.90, 1.50, 3.40 };

        Console.WriteLine("Lista de productos:");

        double total = 0;

        // Mostrar productos y sumar precios
        foreach (double precio in productos)
        {
            Console.WriteLine($"Producto con precio: {precio}€");
            total += precio;
        }

        Console.WriteLine($"\nPrecio total: {total}€");

        // Descuento del 15%
        double totalConDescuento = total * 0.85;
        Console.WriteLine($"Total con descuento del 15%: {totalConDescuento}€");
    }
}
