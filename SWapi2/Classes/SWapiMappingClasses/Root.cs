namespace SWapi2.Classes.SWapiMappingClasses
{
    ///<Summary>
    ///    Generic Root class for unfiltered API calls
    ///</Summary>
    public class Root
    {
        public int count { get; set; }
        public object? next { get; set; }
        public object? previous { get; set; }
        public List<Object>? results { get; set; }
    }
}
