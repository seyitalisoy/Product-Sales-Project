using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitInStock=20,UnitPrice=5},
                new Product{ProductId=2,CategoryId=3,ProductName="Kamera",UnitInStock=10,UnitPrice=5000},
                new Product{ProductId=3,CategoryId=2,ProductName="Klavye",UnitInStock=30,UnitPrice=50},
                new Product{ProductId=4,CategoryId=2,ProductName="Telefon",UnitInStock=213,UnitPrice=50000},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitInStock=20,UnitPrice=52},


            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => product.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId == categoryId).ToList();
            
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p=> p.ProductId == product.ProductId); //single
            productToUpdate.CategoryId=product.CategoryId;
            productToUpdate.ProductName=product.ProductName;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.UnitInStock=product.UnitInStock;
        }
    }
}
