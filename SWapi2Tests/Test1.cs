
using 
namespace SWapi2Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestPersonCount()
        {
            // Arrange
            string filmUrl = "https://swapi.dev/api/films/1/";
            List<Planet> planets = PlanetsForFilmM.GetPlanetsForFilm(filmUrl);
            List<Person> persons = new List<Person>();
            foreach (Planet planet in planets)
            {
                persons.AddRange(planet.residents);
            }
            // Act
            int personCount = persons.Count;
            // Assert
            Assert.AreEqual(18, personCount);

        }
    }
}
