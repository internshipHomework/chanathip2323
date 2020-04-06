using System.Collections.Generic;
using System.IO;
using System.Collections;
using System;
namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Testhome proall = new Testhome();
            proall.AddProductToCart();
            Console.ReadLine();
        }
    }
}
public interface IHomework09
{
    IEnumerable<IProduct> GetAllProducts();
    void AddProductToCart(IProduct product);
    IEnumerable<IProduct> GetProductsInCart();
}
public interface IProduct
{
    string SKU { get; set; }
    string Name { get; set; }
    double Price { get; set; }
}
public class Testhome : IHomework09
{
    public void AddProductToCart()
    {
        using (var reader = new StreamReader(@"product.csv"))
        {
            List<string> SKU = new List<string>();
            List<string> Name = new List<string>();
            List<string> Price = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                SKU.Add(values[0]);
                Name.Add(values[1]);
                Price.Add(values[2]);
            }
            string[] array1 = new string[10];
            ArrayList myAL = new ArrayList();
            int sum = 0;
            int count = 1;
            Console.WriteLine("Products in your cart are");
            Console.WriteLine("none");
            Console.WriteLine("---");
            Console.WriteLine("Total amount: 0.00 baht");
            Console.WriteLine("Please input a product key:");
            while (count <= 100)
            {
                string inputid = Console.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    if (SKU[i] == inputid)
                    {
                        string v = Price[i];
                        int x = Convert.ToInt32(v);
                        sum = sum + x;
                        array1[i - 1] = Name[i];
                    }
                }
                count = count + 1;
                Console.WriteLine("Products in your cart are");
                Console.WriteLine("{0}", string.Join(" ", array1));
                Console.WriteLine("-------");
                Console.WriteLine("Total amount: " + sum + " Bath");
                Console.WriteLine("Please input a product key:");
            }
        }
    }
    public void AddProductToCart(IProduct product)
    {
    }
    public IEnumerable<IProduct> GetAllProducts()
    {
        throw new NotImplementedException();
    }
    public IEnumerable<IProduct> GetProductsInCart()
    {
        throw new NotImplementedException();
    }
}
public class Testproduct : IProduct
{
    private string _sku;
    public string SKU
    {
        get { return _sku; }
        set { _sku = value; }
    }
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private string _price;
    public string Price
    {
        get { return _price; }
        set { _price = value; }
    }
    double IProduct.Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}



