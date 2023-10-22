using EKArtDAL;
using EKArtDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKart_consoleApp
{
    public class Program
    {
        static EKartDBContext context;
        static EKartRepository repository;
        static Program()
        {
            context = new EKartDBContext();
            repository = new EKartRepository(context);
        }
        static public void Main(string[] args)
        {
            Console.WriteLine("This is our First web application");
            //---------------------------------------------------------------------------------------------
            //bool result = repository.AddCategory("FaceWash");

            //if (result)
            //{
            //    Console.WriteLine("new category added");
            //}
            //else
            //{
            //    Console.WriteLine("some error occured");
            //}



            //----------------------------------------------------------------------------------------------
            Product productone = new Product();
            productone.ProductId = 1;
            productone.ProductName = "Garnier FaceWash";
            productone.Price = 100;
            productone.CategoryId = 0;
            productone.QuantityAvailable = 10;

            bool result1 = repository.AddProductsUsingParams(productone);
            if (result1)
            {
                Console.WriteLine("Product details added");
            }
            else
            {
                Console.WriteLine("some error occured");
            }

        }




    }
}
