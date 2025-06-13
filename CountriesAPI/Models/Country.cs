namespace CountriesAPI.Models
{
    public class Country
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required int Population { get; set; }
        public required string Capital { get; set; }
        public string? LargestCity {  get; set; }

        public string? Religion { get; set; }
        public required double Area { get; set; }
        public int? GDPTotal { get; set; }
        public int? GDPPerCapita { get; set; }
        public string Language { get; set; } 
        public List<City> Cities { get; set; } 

    }
}
