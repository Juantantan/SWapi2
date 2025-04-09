using Newtonsoft.Json;
using RestSharp;
using SWapi2.Classes;
using SWapi2.Classes.HelperClasses;
using SWapi2.Classes.SWapiMappingClasses;
using SWapi2.Interfaces;

namespace Star_Wars_API_Interface_Restful.Classes
{
    ///<Summary>
    ///    Contains method to get the filled SelectedFilmParent class object for the selected film
    ///</Summary>
    public class FilmParent : IGetSelectedFilmParent
    {
        ///<Summary>
        ///    Gets the SelectedFilmParent class object for the selected film, its related data and child data
        ///</Summary> 
        public static SelectedFilmParent GetSelectedFilmParent(string FilmURL)
        {
            Film _film;
            int filmIndex = FilmURL.IndexOf("films/");
            string filmId = FilmURL.Substring(filmIndex + 5);
            filmId = filmId.Replace("/", "");
            RestResponse? response = ResponseGovernor.GetResponse($"{SwapiUrlConstants.FilmsRequestURL}/{filmId}");
            _film = JsonConvert.DeserializeObject<Film>(response.Content);
            SelectedFilmParent _selectedFilm = new SelectedFilmParent
            {
                title = _film.title,
                episode_id = _film.episode_id,
                opening_crawl = _film.opening_crawl,
                release_date = _film.release_date,
                url = _film.url,
                planets = PlanetsForFilmM.GetPlanetsForFilm(_film.url),
                personHomeworlds = PersonsByHomeworldForFilmM.GetPersonsByHomeworldForFilm(_film.url),
            };
            return _selectedFilm;
        }
    }
}
