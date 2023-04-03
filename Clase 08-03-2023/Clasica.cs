
//CLASE HAMBURGUESA CLASICA
public class Hamburguesaclasica
{
    public string Tipopan { get; set; }
    public string Tipocarne { get; set; }
    public string Adicionales { get; set; }
    public int precio { get; set; }
    public int x, y, z, a, total;
    public int[] listaadicionales = new int[4];
    List<string> adicionales = new List<string>();
    public Hamburguesaclasica()
    {
        precio = 200;
        Console.WriteLine("Hamburguesa clásica");
        Console.WriteLine("Seleccione su tipo de pan" + "\n\t1.Agua" + "\n\t2.Sobao");
        x = Convert.ToInt32(Console.ReadLine());
        if (x == 1)
        {
            Tipopan = "Agua";
        }
        else
        {
            Tipopan = "Sobao";
        }
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

        Console.WriteLine("Seleccione máximo cuatro ingredientes adicionales" + "\n\t1.Bacon RD$90" + "\n\t2.Cebolla caramelizada RD$60" + "\n\t3.Pepinillos RD$50" + "\n\t4.Lechuga RD$45" + "\n\t5.Platano maduro RD$85" + "\n\t6.Queso extra RD$70" + "\n\t7.MOSTRAR BALANCE DE CUENTA" + "\n\t0.PAGAR");

        a = adicionales.Count;
        z = Convert.ToInt32(Console.ReadLine());
        while ((z != 0) && (a < 4))
        {
            if (z == 1)
            {
                adicionales.Add("Bacon RD$90");
                precio = precio + 90;
                z = Convert.ToInt32(Console.ReadLine());
                a = adicionales.Count;
            }
            else if (z == 2)
            {
                adicionales.Add("Cebolla caramelizada RD$60");
                precio = precio + 60;
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
                adicionales.Add("Platano maduro RD$85");
                precio = precio + 85;
                z = Convert.ToInt32(Console.ReadLine());
                a = adicionales.Count;
            }
            else if (z == 6)
            {
                adicionales.Add("Queso extra RD$70");
                precio = precio + 70;
                z = Convert.ToInt32(Console.ReadLine());
                a = adicionales.Count;
            }
            else if (z == 7)
            {
                Console.WriteLine("BALANCE CUENTA" + "\n\tPrecio base hamburguesa clásica RD$200");
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
        if (a == 4)
        {
            Console.WriteLine("Su hamburguesa ya tiene los cuatro ingredientes adicionales, proceda a pagar");
            Console.WriteLine("BALANCE CUENTA" + "\n\tPrecio base hamburguesa clásica RD$200");
            foreach (string item in adicionales)
                Console.WriteLine("\n\t" + item);
            total = precio;
            Console.WriteLine("\n\tTOTAL= " + precio);
            Console.WriteLine("GRACIAS POR SU COMPRA");
        }
        if (z == 0)
        {
            Console.WriteLine("BALANCE CUENTA" + "\n\tPrecio base hamburguesa clásica RD$200");
            foreach (string item in adicionales)
                Console.WriteLine("\n\t" + item);
            total = precio;
            Console.WriteLine("\n\tTOTAL= " + precio);
            Console.WriteLine("GRACIAS POR SU COMPRA");
        }
    }
}