using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data,string message):base(data,false,message){} //data+success+mesaj

        public ErrorDataResult(T data) : base(data, false){} //data+success

        public ErrorDataResult():base(default,false){ } //success
    }
}
