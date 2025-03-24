using SWapi2.Classes.SWapiMappingClasses;
using System.Collections.Generic;

namespace SWapi2.Interfaces
{
    ///<summary>
    ///    Interface abstract method to a List of PersonHomeworld classes
    ///</summary>
    public interface IPersonsByHomeworldForFilm
    {
        abstract static List<PersonHomeworld>? GetPersonsByHomeworldForFilm(string FilmUrl);
    }
}
