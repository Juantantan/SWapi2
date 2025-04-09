using RestSharp;
using SWapi2.Classes.Logging;

namespace SWapi2.Classes.HelperClasses
{
    internal static class ResponseGovernor
    {
        ///<Summary>
        ///    Gets a List of page URLs. swapi.dev returns 10 results per page
        ///    Can be used generically for any reponse that has a count over 10
        ///</Summary>
        static public RestResponse? GetResponse(string ResourceSuffixURL)
        {
            RestResponse response;
            try
            {
                RestClient client = new RestClient(SwapiUrlConstants.BaseURL);
                response = client.Execute(new RestRequest(ResourceSuffixURL));
                if (response.ErrorException != null)
                {
                    ErrorLogging.WriteToLog(@$"Handled Rest Exception\n{response.ErrorException}");
                    return null;
                }
                return response;
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToLog(@$"Exception\n Method: RestResponse.GetResponse\n Message: {ex.Message}");
                return null;
            }
        }
    }
}
