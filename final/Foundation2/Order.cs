class Order
{
    private static List<Product> products = new List<Product>();

    // Order(string name)
    // {   

    // }

    public static List<Product> GetProducts()
    {
        return products;
    }
    public static void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void WritePackingLabel()
    {
        Console.WriteLine();
        foreach (Product product in products)
        {
            Console.WriteLine(product.GetProductName() + " " + product.GetID() + "/n");
        }
        Console.WriteLine();
    }
    // public void WriteShippingLabel()
    // {
    //     Console.WriteLine();
    // }
}