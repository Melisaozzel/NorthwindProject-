using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message){} //data+success+mesaj

        public SuccessDataResult(T data) : base(data, true){} //data+success

        public SuccessDataResult():base(default,true){ } //success
    }
}
