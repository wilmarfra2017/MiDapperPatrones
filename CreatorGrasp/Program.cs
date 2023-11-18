
//El patrón Creator de GRASP sugiere que una clase B (OrderItem) debería ser responsable de crear instancias de la clase A (Product) si una de las siguientes es verdadera:

//OrderItem (B) agrega objetos de Product (A).
//OrderItem (B) utiliza objetos de Product (A).
//OrderItem (B) tiene la inicialización de datos para Product (A).


OrderItem item = new OrderItem("Laptop", 1000, 2);
decimal totalCost = item.GetTotalCost();
Console.WriteLine($"El costo total del pedido es: {totalCost}");


