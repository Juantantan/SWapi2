using SWapi2.Classes;
using SWapi2.Classes.SWapiMappingClasses;
using SWapi2.Interfaces;

namespace SWapi2.Classes
{
    ///<Summary>
    ///    Contains single method to get a List of PersonHomeworld objects
    ///</Summary> 
    public class PersonsByHomeworldForFilmM : IPersonsByHomeworldForFilm
    {
        ///<Summary>
        ///    Gets a List of PersonHomeworld objects.
        ///    - Gets all people by paging through the Person API then filters for the given film.
        ///    - Gets the Homeworld for each person and returns a PersonHomeworld List.
        ///</Summary> 
        public static List<PersonHomeworld>? GetPersonsByHomeworldForFilm(string FilmUrl)
        {
            List<Person>? allPersons = AllPeople.GetAllPersons();
            if (allPersons == null)
            {
                return null;
            }
            IEnumerable<Person> personsFilteredByFilm;
            List<PersonHomeworld> personHomeworlds = new List<PersonHomeworld>();
            personsFilteredByFilm = allPersons.Where(p => p.films.Contains(FilmUrl));

            foreach (Person person in personsFilteredByFilm)
            {
                int planetIndex = person.homeworld.IndexOf("planets/");
                string planetId = person.homeworld.Substring(planetIndex + 8);
                planetId = planetId.Replace("/", "");
                Planet planet = PlanetsM.GetPlanet(planetId);
                PersonHomeworld personHomeworld = new PersonHomeworld
                {
                    Person = person.name,
                    Homeworld = planet.name
                };
                personHomeworlds.Add(personHomeworld);
            }
            var personHomeworldsOrdered = personHomeworlds.OrderBy(p => p.Homeworld).ThenBy(p => p.Person);
            return personHomeworldsOrdered.ToList<PersonHomeworld>();
        }
    }
}
