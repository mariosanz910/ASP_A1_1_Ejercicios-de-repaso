public class producto
{
    public string nombre;
    public string descripción;
    public double precio;

    public static void Main()
    {
        producto producto1 = new producto();
        producto1.nombre = "Camiseta";
        producto1.descripción = "Camiseta de algodón";
        producto1.precio = 15.99;
        producto producto2 = new producto();
        producto2.nombre = "Pantalones";
        producto2.descripción = "Pantalones vaqueros";
        producto2.precio = 39.99;
        producto producto3 = new producto();
        producto3.nombre = "Zapatillas";
        producto3.descripción = "Zapatillas deportivas";
        producto3.precio = 59.99;
        double total = producto1.precio + producto2.precio + producto3.precio;
        Console.WriteLine($"Producto 1: {producto1.nombre}, Descripción: {producto1.descripción}, Precio: {producto1.precio}€");
        Console.WriteLine($"Producto 2: {producto2.nombre}, Descripción: {producto2.descripción}, Precio: {producto2.precio}€");
        Console.WriteLine($"Producto 3: {producto3.nombre}, Descripción: {producto3.descripción}, Precio: {producto3.precio}€");
        Console.WriteLine($"Total de la compra: {total}€");
    }
}