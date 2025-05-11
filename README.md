# SWapi2
![Red 5](https://github.com/Juantantan/SWapi2/blob/239dad8a13c91c1807f455b6ce6a9c260ed7d091/SWapi2/images/Red%205.jpg)
## About
Star Wars API Interface, which uses the star Wars Web API at [swapi.dev](https://swapi.dev/api/) 

## Dependencies
- Newtonsoft.Json 13.0.3
- RestSharp 112.1.0
- .NET SDK 8.0.407
- .NET Runtime 8.0.14
- ResSharp.Serilog.Auto 1.6.0
- Serilog.Sinks.File 6.0.0

## Web api calls
Limiting the total number of round trip requests to the web api is important. 
For instance, there are 81 characters in total but each can either only be selected individually (example: "https://swapi.dev/api/people/1/") or by groups of 10 per page. If you try to request all characters at once ("https://swapi.dev/api/people/"), you get a page of the first 10 characters. 
This is equivalent to qualifying the page for page 1 ("https://swapi.dev/api/people/?page=1").
This means that if you are filtering by film, you can't get it's characters by one api call because they could be on any page. 
The film with the most characters (Attack of the Clones), has 40 characters, out of the 81 total. To list all of these, you could make 40 api calls, one for each character, as the character URLs are all returned in the film response as an array of charaacter URLs. 
Alternatively, you can get all the characters in 9 pages (81 / 10 plus one remainder) and then filter these on the film URL. This is the approach used here, which uses 9 calls, as opposed to up to 40 (for Attack of the Clones).
