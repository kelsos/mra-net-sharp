using System.Net;

namespace mraSharp.Classes
{
    public static class NetworkOperations
    {
        /// <summary>
        /// Determines whether [internet is up].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [internet is up]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsInternetUp()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com"))
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