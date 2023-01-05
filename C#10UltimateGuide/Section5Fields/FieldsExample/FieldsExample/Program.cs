using System;

class Sample
{
    static void Main()
    {
        const string developerName = "tibi";
        Product product1, product2, product3;

        product1 = new Product();
        Product.TotalNoProducts++;

        product2 = new Product();
        product3 = new Product();

        product1.productId = 1001;
        product1.productName = "Tablet";
        product1.cost = 10;
        product1.quantityInStock = 20;

        Console.WriteLine(product1.productName + product1.productName);

        double totalCostOfStockForProduct1 = product1.cost * product1.quantityInStock;
        Console.WriteLine(totalCostOfStockForProduct1);
        Console.WriteLine(Product.TotalNoProducts);
        Console.WriteLine(Product.CategoryName);
        Console.WriteLine(product1.dataOfPurchase);
        Console.WriteLine(developerName);
        Console.ReadKey();
    }
}

public class InternationalProduct : Product
{

}

public class OtherClass2
{

}