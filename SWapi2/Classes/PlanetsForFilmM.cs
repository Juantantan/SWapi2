using Newtonsoft.Json;
using RestSharp;
using SWapi2.Classes.HelperClasses;
using SWapi2.Classes.SWapiMappingClasses;
using SWapi2.Interfaces;

namespace SWapi2.Classes
{
    ///<Summary>
    ///    Contains method GetPlanetsForFilm, which gets a List of filled Planet class objects for a film
    ///</Summary>
    internal class PlanetsForFilmM : IGetPlanetsForFilm
    {
        ///<Summary>
        ///    Gets a List of all Planet objects then filters for the given film
        ///</Summary>
        public static List<Planet> GetPlanetsForFilm(string FilmUrl)
        {
            IEnumerable<Planet> allPlanets;
            IEnumerable<Planet> planetsFilteredByFilm;
            var client = new RestClient(SwapiUrlConstants.BaseURL);
            RestResponse? response = ResponseGovernor.GetResponse($"{SwapiUrlConstants.PlanetsRequestURL}");
            allPlanets = JsonConvert.DeserializeObject<PlanetRoot>(response.Content).results;
            planetsFilteredByFilm = allPlanets.Where(p => p.films.Contains(FilmUrl)).OrderBy(p => p.name);
            return planetsFilteredByFilm.ToList<Planet>();
        }
    }
}
