using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //Generic Repository Design Pattern
    public interface ICategoryDal:IEntityRepository<Category>
    {
      
    }
}
