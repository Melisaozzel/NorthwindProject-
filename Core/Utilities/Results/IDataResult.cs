using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public interface IDataResult <T>:IResult    // Bu yapı  Iresult icindeki yapıları döndürüp ekstra olarak servisler içinde herhangi bi dönüş tipini de T ile  kabul edip döndürecek.
    {
        T Data { get; }
    }
}
