using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        public List<Product> GetByUnitePrice(decimal min, decimal max);

        List<ProductDetailDto> getProductDetailDtos();

    }
}
