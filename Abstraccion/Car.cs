

public class Car : Vehicle
{
    public Car(string color, int maximumSpeed) : base(color, maximumSpeed) { }

    public override void StartVehicle()
    {
        Console.WriteLine("El carro ha arrancado.");
    }

    public override void StopVehicle()
    {
        Console.WriteLine("El carro se ha detenido.");
    }
}