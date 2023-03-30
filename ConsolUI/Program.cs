using System;
using Business;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsolUI
{
    class Program
    {
        
        //DTO: Data Transformation Object 

        static void Main(string[] args)
        {
           ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
           ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            foreach (var product in productManager.GetByUnitePrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }

            foreach (var product in productManager.GetProductDetailDtos())
            {
                Console.WriteLine(product.ProductName+"/"+product.CategoryName);
            }

        }
    }
}
