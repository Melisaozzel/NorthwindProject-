using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;


namespace Core.DataAccess
{
    //Generic Constraint
    //T :class : referans tip olabilir demek.class olmak zorunda değil
    //IEntity: IEntity olabilir veya onu implement eden classlardan olabilir. customer, product gibi
    // new() : new'lenebilir demek. interface new'lenemeyeceği için artık Ientity değil sadece onu implement eden classlar olabilir. => customer, product
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T,bool>>filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
