using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        public List<Product> _products;
        public InMemoryProductDal() => _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 },
                new Product{ProductId=1,CategoryId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3 },
                new Product{ProductId=1,CategoryId=3,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2 },
                new Product{ProductId=1,CategoryId=4,ProductName="Klavye",UnitPrice=150,UnitsInStock=65 },
                new Product{ProductId=1,CategoryId=5,ProductName="Fare",UnitPrice=85,UnitsInStock=1}

            };

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }
        public List<Product> GetAll()
        {
            return _products;
        }
        public void Delete(Product product)
        {
            Product producToDelete;
            /*  foreach (var p in _products)
              {
                  if(product.ProductId==p.ProductId)
                  {
                      producToDelete = p;
                  }
              }
            */
            producToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(producToDelete);
        }
        public void Update(Product product)
        {
            Product producToUpdate; producToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            producToUpdate.ProductName = product.ProductName;
            producToUpdate.CategoryId = product.CategoryId;
            producToUpdate.UnitPrice = product.UnitPrice;
            producToUpdate.UnitsInStock = product.UnitsInStock;

        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    
    }
}
