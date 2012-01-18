using System.Net;

namespace mraNet.Classes
{
    public static class NetworkOperations
    {
        /// <summary>
        /// Determines whether [internet is up].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [internet is up]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsConnectivityAvailable()
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