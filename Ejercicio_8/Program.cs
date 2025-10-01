public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Dame tres productos: ");
        string producto1 = Console.ReadLine();
        Console.WriteLine("Dame el precio del producto 1: ");
        double precio1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Dame el producto 2: ");
        string producto2 = Console.ReadLine();
        Console.WriteLine("Dame el precio del producto 2: ");
        double precio2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Dame el producto 3: ");
        string producto3 = Console.ReadLine();
        Console.WriteLine("Dame el precio del producto 3: ");
        double precio3 = double.Parse(Console.ReadLine());
        double total = precio1 + precio2 + precio3;
        Console.WriteLine($"El total de la compra es: {total} euros.");
    }
}