using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace mraSharp
{
   public static class NetworkOperations
   {
      /// <summary>
      /// Determines whether [internet is up].
      /// </summary>
      /// <returns>
      ///   <c>true</c> if [internet is up]; otherwise, <c>false</c>.
      /// </returns>
      public static bool isInternetUp()
      {
         try
         {
            using (var client = new WebClient())
            using (var stream = client.OpenRead("http://www.google.com"))
            {
               return true;
            }
         }
         catch
         {
            return false;
         }
      }
   }
}