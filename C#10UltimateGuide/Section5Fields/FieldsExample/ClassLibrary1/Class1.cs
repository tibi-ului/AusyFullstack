public class Product
{
    public int productId;
    public string productName;
    public double cost;
    public int quantityInStock;
    public static int TotalNoProducts;

    public const string CategoryName = "Electronics";
    public readonly string dataOfPurchase;

    public Product()
    {
        dataOfPurchase = System.DateTime.Now.ToShortDateString();
    }
}

public class DomesticProduct : Product
{
    public void Method1()
    {

    }
}

public class OtherClass
{

}