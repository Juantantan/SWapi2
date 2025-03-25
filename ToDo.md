# To dos
## Web api Calls
Limiting the total number of round trip requests to the web api is important. 
For instance, there are 81 characters in total but each can either only be selected individually (example: "https://swapi.dev/api/people/1/") or by groups of 10 per page. If you try to request all characters at once ("https://swapi.dev/api/people/"), you get a page of the first 10 characters. 
This is equivalent to qualifyiung the page for page 1 ("https://swapi.dev/api/people/?page=1") This means that if you are filtering by film, you can't get it's characters by one api call because they could be on any page. 
The film with the most characters (Attack of the Clones), has 40 characters, out of the 81 total. To list all of these, you could make 40 api calls, one for each character, as the chracter URLs are all returned in the film response as an array of charaacter URLs. 
Alternatively, you can get all the characters in 9 pages (81 / 10 plus one remainder) and then filter these on the film URL. This is the approach used here, which uses 9 calls, as opposed to up to 40 (for Attack of the Clones).

## Asynchronous api calls
When a film is selected, this interface needs to make several api calls:
- several to Fill the Planet List 
- several to get all the characters then filter them by film
  
It might be good to make each set of calls separate, so that they can be run asynchronously. That way, the planets List would be visible first, then the Characters by Homeworld List could be displayed.
The crawl text is part of the base film request, so that can be brought back immediately.

