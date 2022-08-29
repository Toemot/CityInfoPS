namespace CityInfo.API.Models
{
    /// <summary>
    /// DTO for a city without point of interests
    /// </summary>
    public class CityWithoutPointsOfInterestDto
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// the description
        /// </summary>
        public string? Description { get; set; }
    }
}
