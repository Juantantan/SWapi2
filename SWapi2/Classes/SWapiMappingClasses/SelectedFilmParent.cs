namespace SWapi2.Classes.SWapiMappingClasses
{
    ///<Summary>
    ///    Hierarchical Class for Selected Film
    ///</Summary>
    public class SelectedFilmParent
    {
        public required string title { get; set; }
        public required int episode_id { get; set; }
        public required string opening_crawl { get; set; }
        public string? director { get; set; }
        public string? producer { get; set; }
        public required string release_date { get; set; }
        public List<Person>? characters { get; set; }
        public List<Planet>? planets { get; set; }
        public List<PersonHomeworld>? personHomeworlds { get; set; }
        public List<string>? starships { get; set; }
        public List<string>? vehicles { get; set; }
        public List<string>? species { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string? url { get; set; }
    }
}
