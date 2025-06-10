namespace CountriesAPI.Models
{
    public class Country
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required int Population { get; set; }
        public required City Capital { get; set; }
        public City? LargestCity {  get; set; }

        public string? Religion { get; set; }
        public required int Area { get; set; }
        public int? GDPTotal { get; set; }
        public int? GDPPerCapita { get; set; }
        public List<Language> OfficialLanguages { get; set; } = null!;
        public List<City> Cities { get; set; } = null!;

    }
}
