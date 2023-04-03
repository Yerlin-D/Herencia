//HAMBURGUESA PREMIUM
public class Hamburguesapremium
{
    public string Tipopan { get; set; }
    public string Tipocarne { get; set; }
    public int precio { get; set; }
    public int x, y;
    public Hamburguesapremium()
    {
        precio = 450;
        Console.WriteLine("Hamburguesa premium");
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
        Console.WriteLine("BALANCE CUENTA" + "\n\tPrecio base hamburguesa premium RD$450" + "\n\tPapitas" + "\n\tRefresco");
        Console.WriteLine("\n\tTOTAL= " + precio);
        Console.WriteLine("GRACIAS POR SU COMPRA");
    }
}