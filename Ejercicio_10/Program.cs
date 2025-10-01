using System;
using System.Collections.Generic;

// Clase base
class Producto
{
    private string nombre;
    private double precio;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public double Precio
    {
        get { return precio; }
        set
        {
            if (value < 0)
                precio = 0;   // no puede ser negativo
            else
                precio = value;
        }
    }
}

// Clase derivada
class ProductoDetallado : Producto
{
    private Dictionary<string, string> caracteristicas = new Dictionary<string, string>();

    // Propiedad indexada
    public string this[string clave]
    {
        get
        {
            if (caracteristicas.ContainsKey(clave))
                return caracteristicas[clave];
            else
                return "No definido";
        }
        set
        {
            caracteristicas[clave] = value;
        }
    }

    // Método para mostrar datos
    public void Datos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: {Precio}€");
        Console.WriteLine("Características:");
        foreach (var item in caracteristicas)
        {
            Console.WriteLine($" - {item.Key}: {item.Value}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProductoDetallado p1 = new ProductoDetallado();
        p1.Nombre = "Laptop";
        p1.Precio = 1200;
        p1["peso"] = "2 Kg";
        p1["color"] = "Negro";

        ProductoDetallado p2 = new ProductoDetallado();
        p2.Nombre = "Teléfono";
        p2.Precio = 800;
        p2["peso"] = "200 g";
        p2["pantalla"] = "6 pulgadas";

        ProductoDetallado p3 = new ProductoDetallado();
        p3.Nombre = "Cámara";
        p3.Precio = -500; // probar precio negativo → se guarda 0
        p3["resolucion"] = "24 MP";
        p3["lente"] = "50 mm";

        // Mostrar datos
        p1.Datos();
        p2.Datos();
        p3.Datos();
    }
}
