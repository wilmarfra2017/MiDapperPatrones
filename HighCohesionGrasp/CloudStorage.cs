public class CloudStorage : IStorage
{
    public void Save(string data)
    {
        Console.WriteLine("Guardando datos en: " + data);
    }
}