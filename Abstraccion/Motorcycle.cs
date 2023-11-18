public class Motorcycle : Vehicle
{
    public Motorcycle(string color, int maximumSpeed) : base(color, maximumSpeed) { }

    public override void StartVehicle()
    {
        Console.WriteLine("La motocicleta ha arrancado.");
    }

    public override void StopVehicle()
    {
        Console.WriteLine("La motocicleta se ha detenido.");
    }
}