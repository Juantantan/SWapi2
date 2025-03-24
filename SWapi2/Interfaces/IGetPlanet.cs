using SWapi2.Classes.SWapiMappingClasses;

namespace SWapi2.Interfaces
{
    ///<summary>
    ///    Interface abstract method to get Planet
    ///</summary>
    public interface IGetPlanet
    {
        abstract static Planet GetPlanet(string PlanetId);
    }
}
