using refazendo.Entities;
using refazendo.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter Client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new Order();
order.Clients = new Client(name, email, date);
order.Status = status;
order.Moment = DateTime.Now;

Console.Write("How many items to this order: ");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    Console.WriteLine("Enter #" + (i + 1) + " item data:");
    Console.Write("Product Name: ");
    string P_name = Console.ReadLine();
    Console.Write("Product Price: ");
    double P_price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(P_name, P_price);
    OrderItem item = new OrderItem(quantity, P_price);
    item.Product = product;
    order.AddItem(item);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY");
Console.WriteLine("Order moment: " + order.Moment);
Console.WriteLine("Order Status: " + order.Status);
Console.WriteLine("Client: " + order.Clients.Name + " (" + order.Clients.BirthDate.ToString("dd/MM/yyyy") + ") - " + order.Clients.Email);

Console.WriteLine("Order Items: ");


foreach (OrderItem item in order.Items)
{
    Console.WriteLine(item.Product.Name + ", " + item.Product.Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + item.Quantity + ", SubTotal: " + item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
}
Console.WriteLine("Total Price: " + order.Total().ToString("F2", CultureInfo.InvariantCulture));
