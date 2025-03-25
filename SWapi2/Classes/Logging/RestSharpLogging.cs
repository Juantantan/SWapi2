using RestSharp;
using Serilog;
using Serilog.Sinks;
namespace SWapi2.Classes.Logging
{
    internal static class RestSharpLogging
    {

        public static void RestSharpLogger(string UrlRequestSuffix)
        {
            string projectDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string LogDirectory = $@"{projectDir}\Logs";
            if (!Directory.Exists(@$"{LogDirectory}"))
            {
                Directory.CreateDirectory(@$"{LogDirectory}");
            }
            string logPath = $@"{LogDirectory}\RestSharpErrorLog.txt";
            if (!File.Exists(@$"{logPath}"))
            {
                File.Create($@"{logPath}").Close();
            }

            Serilog.Formatting.ITextFormatter formatter = new Serilog.Formatting.Display.MessageTemplateTextFormatter("Text");
            // Configure Serilog
            var loggerConfiguration = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(formatter, logPath);// Console();  // Or other sinks
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
