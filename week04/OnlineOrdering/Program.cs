using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedido 1: Cliente dentro de EE. UU. (Envío $5)
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Wireless Mouse", "WM101", 25.50m, 2);
        Product product2 = new Product("Mechanical Keyboard", "KB202", 75.00m, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Pedido 2: Cliente fuera de EE. UU. (Envío $35)
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emma Watson", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Gaming Headset", "HS303", 45.00m, 1);
        Product product4 = new Product("Mouse Pad", "MP404", 15.00m, 3);
        Product product5 = new Product("USB-C Hub", "UC505", 30.00m, 1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Mostrar resultados del Pedido 1
        Console.WriteLine("=========================================");
        Console.WriteLine("ORDER 1 DETAILS:");
        Console.WriteLine("=========================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():0.00}\n");

        // Mostrar resultados del Pedido 2
        Console.WriteLine("=========================================");
        Console.WriteLine("ORDER 2 DETAILS:");
        Console.WriteLine("=========================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():0.00}\n");
    }
}
