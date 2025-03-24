using SWapi2.Classes.SWapiMappingClasses;

namespace SWapi2.Interfaces
{
    ///<summary>
    ///    Interface abstract method to the SelectedFilmParent Parent class
    ///</summary>
    public interface IGetSelectedFilmParent
    {
        abstract static SelectedFilmParent GetSelectedFilmParent(string FilmURL);
    }
}
