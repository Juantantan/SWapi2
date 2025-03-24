using SWapi2.Classes.SWapiMappingClasses;
using System.Collections.Generic;
namespace SWapi2.Interfaces
{
    ///<summary>
    ///    Interface abstract method to get List of Type Film
    ///</summary>
    public interface IGetFilms
    {
        abstract static List<Film> GetFilms();
    }
}
