


public class Program
{
    static void Main(string[]args)
    {
        int EdadMeses, Edad;
        string Nombre;
        Console.WriteLine("Hola vienvenidos a nuetro primer sistemacreado en C#");
        Console.WriteLine("ingresa el nombre para contuinar");
        Nombre = Console.ReadLine();// Para escribir valores de caracter
        Console.WriteLine("Ingrese su edad ");
        Edad = Convert.ToInt32(Console.ReadLine ());//combertir a datos dobule
        EdadMeses = Edad * 12;//calculos matematicos 
        Console.WriteLine(Nombre + "Tu edad en meses es:" + EdadMeses + "Meses");//concatenación
    }






}



