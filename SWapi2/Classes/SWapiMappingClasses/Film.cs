﻿namespace SWapi2.Classes.SWapiMappingClasses
{
    ///<Summary>
    ///    Base Class for Film
    ///</Summary>
    public class Film
    {
        public string? title { get; set; }
        public int episode_id { get; set; }
        public string? opening_crawl { get; set; }
        public string? director { get; set; }
        public string? producer { get; set; }
        public string? release_date { get; set; }
        public List<string>? characters { get; set; }
        public List<string>? planets { get; set; }
        public List<string>? starships { get; set; }
        public List<string>? vehicles { get; set; }
        public List<string>? species { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string? url { get; set; }

    }
}
