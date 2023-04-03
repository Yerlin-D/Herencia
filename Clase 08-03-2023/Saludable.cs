//CLASE HAMBURGUESA SALUDABLE
public class Hamburguesasaludable
{
    public string Tipocarne { get; set; }
    public string Adicionales { get; set; }
    public int precio { get; set; }
    public int x, y, z, a, total;
    public int[] listaadicionales = new int[2];
    List<string> adicionales = new List<string>();
    public Hamburguesasaludable()
    {
        precio = 300;
        Console.WriteLine("Hamburguesa saludable");
        Console.WriteLine("Tipo de pan: Integral");

        Console.WriteLine("Seleccione su tipo de carne" + "\n\t1.Res" + "\n\t2.Pollo");
        y = Convert.ToInt32(Console.ReadLine());
        if (y == 1)
        {
            Tipocarne = "Res";
        }
        else
        {
            Tipocarne = "Pollo";
        }

        Console.WriteLine("Seleccione máximo dos ingredientes adicionales" + "\n\t1.Rucula RD$95" + "\n\t2.Cebolla RD$40" + "\n\t3.Pepinillos RD$50" + "\n\t4.Lechuga RD$45" + "\n\t5.Nueces RD$90" + "\n\t6.MOSTRAR BALANCE DE CUENTA" + "\n\t0.PAGAR");

        a = adicionales.Count;
        z = Convert.ToInt32(Console.ReadLine());
        while ((z != 0) && (a < 2))
        {
            if (z == 1)
            {
                adicionales.Add("Rucula RD$95");
                precio = precio + 95;
                z = Convert.ToInt32(Console.ReadLine());
                a = adicionales.Count;
            }
            else if (z == 2)
            {
                adicionales.Add("Cebolla RD$40");
                precio = precio + 40;
                z = Convert.ToInt32(Console.ReadLine());
                a = adicionales.Count;
            }
            else if (z == 3)
            {
                adicionales.Add("Pepinillos RD$50");
                precio = precio + 50;
                z = Convert.ToInt32(Console.ReadLine());
                a = adicionales.Count;
            }
            else if (z == 4)
            {
                adicionales.Add("Lechuga RD$45");
                precio = precio + 45;
                z = Convert.ToInt32(Console.ReadLine());
                a = adicionales.Count;
            }
            else if (z == 5)
            {
                adicionales.Add("Nueces RD$90");
                precio = precio + 90;
                z = Convert.ToInt32(Console.ReadLine());
                a = adicionales.Count;
            }
            else if (z == 6)
            {
                Console.WriteLine("BALANCE CUENTA" + "\n\tPrecio base hamburguesa saludable RD$300");
                foreach (string item in adicionales)
                    Console.WriteLine("\n\t" + item);
                total = precio;
                Console.WriteLine("\n\tTOTAL= " + precio);
                Console.WriteLine("Continue agregando ingredientes adicionales o precione 0 para pagar");
                a = adicionales.Count;
                Console.WriteLine(a);
                z = Convert.ToInt32(Console.ReadLine());
            }
        }
        if (a == 2)
        {
            Console.WriteLine("Su hamburguesa ya tiene los dos ingredientes adicionales, proceda a pagar");
            Console.WriteLine("BALANCE CUENTA" + "\n\tPrecio base hamburguesa saludable RD$300");
            foreach (string item in adicionales)
                Console.WriteLine("\n\t" + item);
            total = precio;
            Console.WriteLine("\n\tTOTAL= " + precio);
            Console.WriteLine("GRACIAS POR SU COMPRA");
        }
        if (z == 0)
        {
            Console.WriteLine("BALANCE CUENTA" + "\n\tPrecio base hamburguesa saludable RD$300");
            foreach (string item in adicionales)
                Console.WriteLine("\n\t" + item);
            total = precio;
            Console.WriteLine("\n\tTOTAL= " + precio);
            Console.WriteLine("GRACIAS POR SU COMPRA");
        }
    }
}

