namespace CountriesAPI.Models
{
    public class City
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Population { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
