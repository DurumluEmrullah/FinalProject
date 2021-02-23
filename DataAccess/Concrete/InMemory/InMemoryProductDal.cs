using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product(){ ProductId=1,CategoryId=1,ProductName="Elma",UnitPrice=5,UnitsInStock=100},
                new Product(){ ProductId=2,CategoryId=2,ProductName="Klavye",UnitPrice=450,UnitsInStock=100},
                new Product(){ ProductId=3,CategoryId=2,ProductName="Fare",UnitPrice=70,UnitsInStock=100},
                new Product(){ ProductId=4,CategoryId=3,ProductName="Kumbara",UnitPrice=5,UnitsInStock=100},
                new Product(){ ProductId=5,CategoryId=1,ProductName="Armut",UnitPrice=5,UnitsInStock=100}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete= null;
            //LINQ-> Language Integrated Query

            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            

            // classic methot
            /* for(int i =0; i < _products.Count; i++)
             {
                 if (_products[i].ProductId.Equals(product.ProductId))
                     productToDelete = _products[i];
             }*/

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate= null;

            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;

        }
    }
}
