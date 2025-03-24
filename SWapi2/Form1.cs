using Star_Wars_API_Interface_Restful.Classes;
using SWapi2.Classes;
using SWapi2.Classes.Logging;
using SWapi2.Classes.SWapiMappingClasses;

namespace SWapi2
{
    public partial class Form1 : Form
    {
        List<Film>? films;
        List<FilmFieldsForDisplay>? FilmFieldsForDisplays;
        Film? film;
        public Form1()
        {
            InitializeComponent();
            lbxFilms.Visible = false;
            DGVFilms.Visible = false;
            lbxPersonsHomeworld.Visible = false;
            lbxPlanets.Visible = false;
            listBoxPlanets.Visible = false;
            listBoxHomeworlPerson.Visible = false;
            lbxCrawlText.Text = "";
        }

        private void DGVFilms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                lbxCrawlText.Text = "";
                film = films[e.RowIndex];
                SelectedFilmParent selectedFilmParent = FilmParent.GetSelectedFilmParent(film.url);
                if (selectedFilmParent == null || selectedFilmParent.personHomeworlds == null
                    || selectedFilmParent.planets == null || selectedFilmParent.episode_id == 0 || selectedFilmParent.opening_crawl == null || selectedFilmParent.release_date == null)
                {
                    ErrorLogging.WriteToLog("Error: SelectedFilmParent is null or has null properties");
                    lbxWarningMessage.Visible = true;
                    lbxWarningMessage.Text = $"Error: SelectedFilmParent is null or has null properties\n\tView Log";
                    return;
                }

                listBoxPlanets.DataSource = null;
                listBoxPlanets.Items.Clear();
                listBoxHomeworlPerson.Items.Clear();
                listBoxHomeworlPerson.Visible = true;
                lbxPersonsHomeworld.Visible = true;
                lbxPlanets.Visible = true;
                listBoxPlanets.Visible = true;
                listBoxPlanets.DisplayMember = "name";
                listBoxPlanets.DataSource = selectedFilmParent.planets;
                lbxCrawlText.Visible = true;
                lbxCrawlText.Text = selectedFilmParent.opening_crawl;

                selectedFilmParent.personHomeworlds.Sort(delegate (PersonHomeworld pH1, PersonHomeworld pH2) { return pH1.Homeworld.CompareTo(pH2.Homeworld); });

                string homeworldOrdered = "";
                for (int i = 0; i < selectedFilmParent.personHomeworlds.Count; i++)
                {
                    string spacer = new string(' ', 20 - selectedFilmParent.personHomeworlds[i].Homeworld.Length);
                    string homeworldSpacer = new string(' ', selectedFilmParent.personHomeworlds[i].Homeworld.Length);

                    if (i != 0 && selectedFilmParent.personHomeworlds[i].Homeworld != homeworldOrdered)
                    {
                        listBoxHomeworlPerson.Items.Add(Environment.NewLine);
                    }

                    if (selectedFilmParent.personHomeworlds[i].Homeworld != homeworldOrdered)
                    {
                        listBoxHomeworlPerson.Items.Add($"{selectedFilmParent.personHomeworlds[i].Homeworld}{Environment.NewLine}{spacer}\t{selectedFilmParent.personHomeworlds[i].Person}");
                    }
                    else
                    {
                        listBoxHomeworlPerson.Items.Add($"{homeworldSpacer}{spacer}\t{selectedFilmParent.personHomeworlds[i].Person}");
                    }
                    homeworldOrdered = selectedFilmParent.personHomeworlds[i].Homeworld;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxWarningMessage.Visible = false;
            films = AllFilms.GetFilms();
            if (films != null && films.Count > 0)
            {
                lbxFilms.Visible = true;
                DGVFilms.Visible = true;
                lbxCrawlText.Text = "";
                FilmFieldsForDisplays = new List<FilmFieldsForDisplay>();
                foreach (Film film in films)
                {
                    FilmFieldsForDisplay FilmFieldsForDisplay = new FilmFieldsForDisplay();
                    FilmFieldsForDisplay.episode_id = film.episode_id;
                    FilmFieldsForDisplay.title = film.title;
                    FilmFieldsForDisplay.release_date = film.release_date;
                    FilmFieldsForDisplay.opening_crawl = film.opening_crawl;
                    FilmFieldsForDisplay.url = film.url;
                    FilmFieldsForDisplays.Add(FilmFieldsForDisplay);
                }

                DGVFilms.DataSource = FilmFieldsForDisplays;
                DataGridViewElementStates includeFilter = DataGridViewElementStates.Visible;
                DGVFilms.Height = 180;
                DGVFilms.Width = 508;
                listBoxPlanets.Height = 180;
                listBoxHomeworlPerson.Height = 180;
            }
        }
    }
}
