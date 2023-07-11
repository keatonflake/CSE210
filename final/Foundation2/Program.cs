using System;

class Program
{
    static void Main(string[] args)
    {
        // write a program that creates at least two orders with a 2-3 products each.
        // Call the methods to get the packing label, the shipping label, and the total price of the order,
        // Display the results of these methods.

        List<string> randomNames = new List<string>()
        {
            "Alice", "Bob", "Charlie", "David", "Emma","Frank", "Grace", "Henry", "Isabella", "Jack","Katherine", "Liam", "Mia", "Noah", "Olivia","Peter", "Quinn", "Ruby", "Samuel", "Taylor","Ursula", "Victor", "Willow", "Xavier", "Yara", "Zoe"
        };

        List<string> randomStreetNames = new List<string>()
        {
            "123 W. Main Street", "123 W. Oak Avenue", "123 W. Elm Street", "123 W. Cedar Lane","123 W. Maple Road", "123 W. Pine Street", "123 W. Birch Lane", "123 W. Willow Avenue","123 W. Spruce Court", "123 W. Hickory Lane", "123 W. Cypress Road", "123 W. Sycamore Street"
        };
        List<string> randomCities = new List<string>
        {
            "New York", "Los Angeles", "Chicago", "Houston","Phoenix","Philadelphia","San Antonio","San Diego","Dallas","San Jose","Austin","Jacksonville","San Francisco","Columbus","Fort Worth","Indianapolis","Charlotte","Seattle","Denver","Washington, D.C."
        };
        List<string> randomStates = new List<string>
        {
            "Alabama","Alaska","Arizona","Arkansas","California","Colorado","Connecticut","Delaware","Florida","Georgia","Hawaii","Idaho", "Illinois","Indiana","Iowa","Kansas","Kentucky","Louisiana","Maine","Maryland","Massachusetts","Michigan","Minnesota","Mississippi","Missouri","Montana","Nebraska",
        };
        List<string> randomProvances = new List<string>
        {
            "12345","67890","54321","98765","13579","86420","24680","97531","46802","80246","13579","24680","98765","54321","46802","80246","97531","86420","12345","67890"
        };
        List<string> RandomCountries = new List<string>
        {
            "United States","China","India","Brazil","Russia","Japan","Germany","United Kingdom","France","Italy","Canada","South Korea","Australia","Spain","Mexico","Indonesia","Netherlands","Saudi Arabia","Switzerland","Sweden"
        };
        List<string> RandomProductNames = new List<string>
        {
            "Widget","Gizmo","Thingamajig","Doohickey","Whatchamacallit","Doodad","Contraption","Gadget","Gubbins","Grommet","Gimcrack","Gizmo","Gizmology","Gizmonics","Gizmophone","Whizbang","Dinglehopper","Flibbertigibbet","Nincompoop","Widdershins"
        };
        // Collect all the new orders Here
        List<Order> _orders = new List<Order>();

        // while Loop to create a few orders
        int orderCounter = 0;
        while (orderCounter <= 4)
        {
            Customer newCustomer = new Customer();
            newCustomer.SetName(randomNames[GetRandomNumber(0, 25)]);

            Address newAddress = new Address();
            newAddress.SetStreetAddress(randomStreetNames[GetRandomNumber(0, 12)]);
            newAddress.SetCity(randomCities[GetRandomNumber(0, 20)]);
            newAddress.SetState(randomStates[GetRandomNumber(0, 23)]);
            newAddress.SetProvance(randomProvances[GetRandomNumber(0, 20)]);
            newAddress.SetCountry(RandomCountries[GetRandomNumber(0, 20)]);

            Order newOrder = new Order(newCustomer, newAddress);
            
            int productCounter = 0;
            while (productCounter <= 4)
            {

                Product newProduct = new Product();
                newProduct.SetProductName(RandomProductNames[GetRandomNumber(1, 20)]);
                newProduct.SetID(GetRandomNumber(0, 100));
                newProduct.SetPrice(GetRandomNumber(1, 100));
                newProduct.SetQuantity(GetRandomNumber(1, 100));

                newOrder.AddProduct(newProduct);
                productCounter++;
            }
            // add order to list
            _orders.Add(newOrder);
            orderCounter++;
        }
        // call the shipping and packing label methods
        foreach(Order order in _orders)
        {
            order.WriteShippingLabel();
            order.WritePackingLabel();
        }

        int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}