using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
   {
       public static string ProductAdded = "Ürün eklendi"; //static olusturdum cunku tek 1 instance olusması yeterli her yerde aynı instance kullanılabilir.
       public static string ProductNameInvalid = "Ürün ismi geçersiz.";//public oldugu icin pascalCase
       public static string MaintenanceTime = "Sistem bakımda";
       public static string ProductListed = "Ürünler Listelendi";
   }
}
