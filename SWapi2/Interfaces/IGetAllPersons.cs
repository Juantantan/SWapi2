using SWapi2.Classes.SWapiMappingClasses;
using System.Collections.Generic;

namespace SWapi2.Interfaces
{
    ///<summary>
    ///    Interface abstract method to get entire List of Type Person
    ///</summary>
    public interface IGetAllPersons
    {
        abstract static List<Person>? GetAllPersons();
    }
}
