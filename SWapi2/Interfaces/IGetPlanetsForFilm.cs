using SWapi2.Classes.SWapiMappingClasses;
using System.Collections.Generic;

namespace SWapi2.Interfaces
{
    ///<summary>
    ///    Interface abstract method to get Planets for a Film
    ///</summary>
    public interface IGetPlanetsForFilm
    {
        abstract static List<Planet> GetPlanetsForFilm(string FilmURL);
    }
}
