namespace CountriesAPI.Models
{
    public class City
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Population { get; set; }
        public Guid CountryId { get; set; }
        public Country? Country { get; set; }
    }
}
