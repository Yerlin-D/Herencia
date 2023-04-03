using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al menú de Chimi MiBarriga");
        Console.WriteLine("Seleccione su hamburguesa preferida:");
        Console.WriteLine("1.Clásica");
        Console.WriteLine("2.Saludable");
        Console.WriteLine("3.Premium");

        int tipohamburguesa;
        tipohamburguesa = Convert.ToInt32(Console.ReadLine());
        if (tipohamburguesa == 1)
        {
            Hamburguesaclasica hamburguesa = new Hamburguesaclasica();
        }
        else if (tipohamburguesa == 2)
        {
            Hamburguesasaludable hamburguesa = new Hamburguesasaludable();
        }
        else if (tipohamburguesa == 3)
        {
            Hamburguesapremium hamburguesa = new Hamburguesapremium();
        }
    }
}

