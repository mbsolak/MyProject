using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;



namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnityPrice(max:200,min:45))
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
