public class LocalStorage : IStorage
{
    public void Save(string data)
    {
        Console.WriteLine("Guardando datos en: " + data);
    }
}