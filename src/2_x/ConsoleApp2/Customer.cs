namespace ConsoleApp2
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
    }
}