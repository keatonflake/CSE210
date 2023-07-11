public class Product
{
    public string _productName;
    public int _id;
    public int _price;
    public int _quantity;

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductName(string name)
    {
        _productName = name;
    }

    public int GetID()
    {
        return _id;
    }

    public void SetID(int ID)
    {
        _id = ID;
    }

    public int GetPrice()
    {
        return _price;
    }

    public void SetPrice(int price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetTotalPrice()
    {
        return _quantity * _price;
    }


}