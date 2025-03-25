using RestSharp;
using SWapi2.Classes;
using SWapi2.Classes.Logging;

namespace SWapi2.Classes
{
    ///<Summary>
    ///    Contains Helper methods for the application
    ///</Summ
    internal static class HelperMethods
    {
        ///<Summary>
        ///    Gets a List of page URLs. swapi.dev returns 10 results per page
        ///    Can be used generically for any reponse that has a count over 10
        ///</Summary>
        public static List<string> GetPagingURLs(int resourceRootCount)
        {
            List<string> pagingURLs = new List<string>();

            // Work out how many pages of resource results there are
            // 10 results per page. Add 1 extra page for any modulus remainder
            int numberOfPages = resourceRootCount / 10 + (resourceRootCount % 10 == 0 ? 0 : 1);

            for (int iCount = 1; iCount != numberOfPages + 1; iCount++)
            {
                string pagingURL = $"?page={iCount}";
                pagingURLs.Add(pagingURL);
            }
            return pagingURLs;
        }

        ///<Summary>
        ///    Gets a List of page URLs. swapi.dev returns 10 results per page
        ///    Can be used generically for any reponse that has a count over 10
        ///</Summary>
        public static RestResponse GetResponse(string ResourceSuffixURL, string callingMethod)
        {
            RestResponse response;
            try
            {

                RestClient client = new RestClient(SwapiUrlConstants.BaseURL);
                response = client.Execute(new RestRequest(ResourceSuffixURL));
                return response;
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToLog(@$"Calling Methods: {callingMethod}/nMessage: {ex.Message}");
                return null;
            }
        }

    }
}
