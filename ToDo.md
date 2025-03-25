# To dos
## Asynchronous api calls
When a film is selected, this interface needs to make several api calls:
- several to Fill the Planet List 
- several to get all the characters then filter them by film
  
It might be good to make each set of calls separate, so that they can be run asynchronously. That way, the planets List would be visible first, then the Characters by Homeworld List could be displayed.
The crawl text is part of the base film request, so that can be brought back immediately.

## Unit Tests
Whichever test new project type is chosen or Nuget package installed, erros are encountered. This could be because testing packages don't like the Windows version or the fact that the framework is quite new (NET 8.0). 

