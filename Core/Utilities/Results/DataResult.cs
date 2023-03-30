using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T>:Result, IDataResult<T>
    {
        public DataResult(T data,bool success, string message):base(success, message) // base burda Result icindeki constructor a gönderir.
        {
                
        }
        public DataResult(T data,bool success):base(success) // Message göndermek istenmediginde bu constructor kullanılır
        {
            this.Data = data;
        }

        protected DataResult() : base(BASE)
        {
            throw new NotImplementedException();
        }

        public T Data { get; } // IDataResult 'tan geliyor. 
    }
}
