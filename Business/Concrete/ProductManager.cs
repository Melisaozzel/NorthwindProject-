using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Business
{          
    //İş kodları
    public class ProductManager:IProductService
    { 
         IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(default,Messages.MaintenanceTime);
            } 
            return  new SuccessDataResult<List<Product>>(_productDal.GetAll(),(Messages.ProductListed));
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<List<Product>> GetByUnitePrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice <= max && p.UnitPrice >= min));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailDtos()
        {
            return new SuccessDataResult<List<ProductDetailDto>>();
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));

        }

        public IResult Add(Product product)
        {
            //magic strings:"ürün ismi min 2 karakter olmalıdır, ürün basarıyla eklendi vs.."
            if (product.ProductName.Length < 2)
              //  return new ErrorResult("Ürün ismin min 2 karakter olmalıdır.");
               return new ErrorResult(Messages.ProductNameInvalid);
    
            _productDal.Add(product);
            // return new Result(true, "Ürün eklendi");
             return new Result(true, Messages.ProductAdded);

        }
    }
}
