
public delegate void MiDelegado(string mensaje);

public class Program
{
    public static void Main()
    {

        MiDelegado saludar = (mensaje) => {
            Console.WriteLine(mensaje);
        };

        saludar("¡Hola mundo!");

        // delegado para apuntar a un método
        MiDelegado otroSaludo = SaludarMundo;
        otroSaludo("¡Hola de nuevo!");

    }

    public static void SaludarMundo(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}
