public class Order
{
   
    private List<Product> products = new List<Product>();
    private Customer _customer;
    private Address _address;

    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _address = address;
    }
    public List<Product> GetProducts()
    {
        return products;
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void WritePackingLabel()
    {
        foreach (Product product in products)
        {
            Console.WriteLine("Product Name: " + product.GetProductName() + " Product ID: " + product.GetID() + "\n");
        }
    }
    public void WriteShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_address.GetAddressString());
    }
}