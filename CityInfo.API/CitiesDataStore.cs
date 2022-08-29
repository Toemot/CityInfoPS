using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        //public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> cityDtos = new List<CityDto>
        {
            new CityDto
            {
                Id = 1,
                Name = "Chiliwak",
                Description = "A good place to live",
                PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 1,
                             Name = "Central Park",
                             Description = "The most visited urban park in the United States." },
                          new PointOfInterestDto() {
                             Id = 2,
                             Name = "Empire State Building",
                             Description = "A 102-story skyscraper located in Midtown Manhattan." },
                     }
            },
            new CityDto
            {
                Id = 2,
                Name = "Abbortsford",
                Description = "A better place to live",
                    PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 3,
                             Name = "Cathedral of Our Lady",
                             Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans." },
                          new PointOfInterestDto() {
                             Id = 4,
                             Name = "Antwerp Central Station",
                             Description = "The the finest example of railway architecture in Belgium." },
                     }
            },
            new CityDto
            {
                Id = 3,
                Name = "Alberter",
                Description = "The best place to live",
                    PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 5,
                             Name = "Eiffel Tower",
                             Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel." },
                          new PointOfInterestDto() {
                             Id = 6,
                             Name = "The Louvre",
                             Description = "The world's largest museum." },
                     }
            }
        };
    }
}
