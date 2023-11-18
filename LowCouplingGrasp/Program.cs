
       Product laptop = new Product
        {
            Name = "Laptop",
            Price = 1000,
            Discount = new PercentageDiscount(10)  //descuento
        };

        OrderItem orderItem = new OrderItem
        {
            Product = laptop,
            Quantity = 2
        };

        decimal totalCost = orderItem.GetTotalCost();
        Console.WriteLine($"El costo total del pedido es: {totalCost}");

