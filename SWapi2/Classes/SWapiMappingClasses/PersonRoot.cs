namespace SWapi2.Classes.SWapiMappingClasses
{
    ///<Summary>
    ///    Inherited Root class for Persons
    ///</Summary>
    public class PersonRoot : Root
    {
        public int count { get; set; }
        public object? next { get; set; }
        public object? previous { get; set; }
        public List<Person>? results { get; set; }
    }
}
