using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result:IResult
    {


        public Result(bool success, string message):this(success)  // >>>this(success) komutu 2. result constructora success'i göndermeye yarar
        {
            Message = message;   // proplar için set yazmamıştım ama get readonly'dir constructor'da set message set edilebilir.
            // Success=success   // zaten success için baska bir constructor var. bunu tekrar yazıp kendimizi tekrar etmeyelim
        }
        public Result(bool success) // Constructor overloading
        {
            Success = success;
        }


        public bool Success { get; }
        public string Message { get; } // set koymaya gerek yok zaten get readonly'dir constructor'da message set edilebilir.
    }
}
