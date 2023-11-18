class Program
{
    static void Main()
    {
        Car car = new Car("Rojo", 200);
        Motorcycle mot = new Motorcycle("", 0);

        car.StartVehicle();
        mot.StartVehicle();

        car.StopVehicle();
        mot.StopVehicle();

        Console.ReadKey();
    }
}