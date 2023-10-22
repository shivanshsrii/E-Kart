using EKArtDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKArtDAL
{
    public class EKartRepository :EKartDBContext
    {
        private readonly EKartDBContext _context;

        public EKartRepository()
        {
        }

        public EKartRepository(EKartDBContext _repo)
        {
            this._context = _repo;
        }
        //-------------------------------------------------------------------------------------------------
        //methods for category
        public bool AddCategory(string categoryName)
        {
            bool status = false;
            Category category=new Category();   
            category.CategoryName = categoryName;
            try
            {
                _context.Add<Category>(category);
                _context.SaveChanges();
                status = true;

            }
            catch (Exception)
            {

                status = false;
            }
            return status;
        }


        //-------------------------------------------------------------------------------------------------
        //methods for products
        public bool AddProductsUsingParams(int productId,string productName,byte categoryId,decimal price,int quantityAvailable)
        {
            bool status = false;
            try
            {
               Product product = new Product();
                product.ProductId = productId;
                product.ProductName = productName;
                product.CategoryId = categoryId;
                product.Price = price;  
                product.QuantityAvailable = quantityAvailable;
                _context.Products.Add(product);
                _context.SaveChanges();
                status |= true;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(  ex);
                status =false;
            }
            return status;
        }

        public bool AddProductsUsingParams(Product productone)
        {
            throw new NotImplementedException();
        }
    }
}
