using Newtonsoft.Json;
using RestSharp;
using SWapi2.Classes.SWapiMappingClasses;
using SWapi2.Interfaces;

namespace SWapi2.Classes
{
    ///<Summary>
    ///    Gets a filled List of all Person class objects
    ///</Summary>
    internal class AllPeople : IGetAllPersons
    {
        ///<Summary>
        ///    Get complete List of filled Person class Objects
        ///</Summary>
        public static List<Person>? GetAllPersons()
        {
            List<Person>? allPersons = new List<Person>();
            PersonRoot? personRoot = PersonsRootM.GetPersonRoot();
            if (personRoot == null)
            {
                return null;
            }
            List<string> pageURLs = HelperMethods.GetPagingURLs(personRoot.count);
            foreach (string pageURL in pageURLs)
            {
                List<Person>? person = new List<Person>();
                var clientPaging = new RestClient(SwapiUrlConstants.BaseURL);
                RestResponse pageResponse = clientPaging.Execute(new RestRequest($"{SwapiUrlConstants.PeopleRequestURL}{pageURL}"));
                person = JsonConvert.DeserializeObject<PersonRoot>(pageResponse.Content).results;
                allPersons.AddRange(person);
            }
            return allPersons;
        }

    }
}
