using SWapi2.Interfaces;
using SWapi2.Classes.SWapiMappingClasses;
using RestSharp;
using Newtonsoft.Json;
using SWapi2.Classes.HelperClasses;

namespace SWapi2.Classes
{
    ///<Summary>
    ///    Contains method to get a List of all Film class objects
    ///</Summary>
    public class AllFilms : IGetFilms
    {
        ///<Summary>
        ///    Gets a filled List of class objetcs of type Film
        ///</Summary>
        public static List<Film>? GetFilms()
        {
            List<Film>? _films;
            RestResponse? response = ResponseGovernor.GetResponse(SwapiUrlConstants.FilmsRequestURL);
            if (response == null)
            {
                Logging.ErrorLogging.WriteToLog("Error: Response is null");
                return null;
            }
            _films = JsonConvert.DeserializeObject<FilmRoot>(response.Content).results;
            if (_films == null)
            {
                Logging.ErrorLogging.WriteToLog("Error: Films list is null");
                return null;
            }
            return _films;
        }

    }
}
