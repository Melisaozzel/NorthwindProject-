using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>>GetAllByCategoryId(int id);
        public IDataResult<List<Product>> GetByUnitePrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetailDtos();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);

    }
}
