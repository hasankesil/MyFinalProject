﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)


        {


            ProductManager productManager = new ProductManager(new  EfProductDal() );

            foreach (var product in productManager./*GetAllbyCategoryId(2)*/ GetByUnitPrice(50,100) )
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}