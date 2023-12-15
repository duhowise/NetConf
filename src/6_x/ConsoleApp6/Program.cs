namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Use `var context = new CustomerContext();` and `context.Customers.Add(new Customer...);`
            // to manipulate customers in DB. This code shows how value types are used in EF Core, with SQLAlchemy
            // Value semantics are shown - Customer has an Address, which cannot exist without the customer.
        }
    }
}