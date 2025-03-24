namespace SWapi2.Classes.SWapiMappingClasses
{
    ///<Summary>
    ///    Inherited Root class for Films
    ///</Summary>
    public class FilmRoot : Root
    {
        public int count { get; set; }
        public object? next { get; set; }
        public object? previous { get; set; }
        public List<Film>? results { get; set; }
    }
}
