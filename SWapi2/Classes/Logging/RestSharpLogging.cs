using RestSharp;
using Serilog;
namespace SWapi2.Classes.Logging
{
    internal static class RestSharpLogging
    {

        public static void RestSharpLogger(string UrlRequestSuffix)
        {
            // Configure Serilog
            var loggerConfiguration = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console();  // Or other sinks
            var restClientAutologConfiguration = new RestClientAutologConfiguration()
            {
                MessageTemplateForSuccess = "{Method} {Url} responded {StatusCode}",
                MessageTemplateForError = "{Method} {Url} is not good! {ErrorMessage}",
                LoggerConfiguration = loggerConfiguration
            };

            // Create the RestClientAutolog instance
            IRestClient client = new RestClientAutolog("https://swapi.dev/api/", restClientAutologConfiguration);

            // Make a request
            var request = new RestRequest(UrlRequestSuffix, Method.Get);
            var response = client.Execute(request);

            // The request and response will be automatically logged
        }
    }
}
