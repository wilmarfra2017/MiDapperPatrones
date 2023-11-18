


OrderItem item = new OrderItem 
{ Product = new Product { Name = "Laptop", Price = 1000 }, Quantity = 2 };

decimal totalCost = item.GetTotalCost();

Console.WriteLine("Costo total compra: " + totalCost);

