

IStorage localStorage = new LocalStorage();
IStorage cloudStorage = new CloudStorage();


localStorage.Save("local");  
cloudStorage.Save("nube");