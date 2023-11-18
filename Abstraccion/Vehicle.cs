
public abstract class Vehicle
{
    public string Color { get; set; }
    public int MaximumSpeed { get; set; }

    public Vehicle(string color, int maximumSpeed)
    {
        Color = color;
        MaximumSpeed = maximumSpeed;
    }

    public abstract void StartVehicle();
    public abstract void StopVehicle();
}