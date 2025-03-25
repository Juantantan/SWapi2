using Newtonsoft.Json;
using RestSharp;
using SWapi2.Classes.HelperClasses;
using SWapi2.Classes.SWapiMappingClasses;
using SWapi2.Interfaces;

namespace SWapi2.Classes
{
    ///<Summary>
    ///    Contains method GetPlanet, which gets a single, filled Planet class object
    ///</Summary>
    internal class PlanetsM : IGetPlanet
    {
        ///<Summary>
        ///    Gets a Planet object by Planet Id
        ///</Summary>
        public static Planet GetPlanet(string PlanetId)
        {
            Planet planet;
            var client = new RestClient(SwapiUrlConstants.BaseURL);
            RestResponse? response = ResponseGovernor.GetResponse($"{SwapiUrlConstants.PlanetsRequestURL}/{PlanetId}");
            planet = JsonConvert.DeserializeObject<Planet>(response.Content);
            return planet;
        }
    }
}
