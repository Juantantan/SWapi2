﻿using Newtonsoft.Json;
using RestSharp;
using SWapi2.Classes.HelperClasses;
using SWapi2.Classes.Logging;
using SWapi2.Classes.SWapiMappingClasses;
using SWapi2.Interfaces;

namespace SWapi2.Classes
{
    ///<Summary>
    ///    Contains method to get an instance of the PersonRoot class
    ///</Summary> 
    public class PersonsRootM: IGetPersonsRoot
    {
        ///<Summary>
        ///    Gets an instance of the unique PersonRoot class. This class describes the Person child 
        ///</Summary> 

        public static PersonRoot GetPersonRoot()
        {
            RestResponse response;
            PersonRoot personRoot;
            try
            {
                response = ResponseGovernor.GetResponse(SwapiUrlConstants.PeopleRequestURL);
                personRoot = JsonConvert.DeserializeObject<PersonRoot>(response.Content);
            }
            /// <exception cref="JsonReaderException">Thrown when an error occurs during JSON deserialization</exception>
            catch (JsonReaderException ex)
            {
                JsonErrorLogging.WriteToLog(ex.Message);
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToLog(ex.Message);
                return null;
            }

            if (personRoot == null || personRoot.count == 0)
            {
                ErrorLogging.WriteToLog("PersonRoot is null or count is 0");

                return null;
            }
            return personRoot;
        }
    }
}
