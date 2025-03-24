namespace SWapi2.Classes.SWapiMappingClasses
{
    ///<Summary>
    ///    Inherited Root class for Planets
    ///</Summary>
    public class PlanetRoot : Root
    {
        public int count { get; set; }
        public object? next { get; set; }
        public object? previous { get; set; }
        public List<Planet>? results { get; set; }
    }
}
