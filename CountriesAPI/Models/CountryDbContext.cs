using Microsoft.EntityFrameworkCore;

namespace CountriesAPI.Models
{
    public class CountryDbContext : DbContext
    {
        public CountryDbContext(DbContextOptions<CountryDbContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set;}
        public DbSet<City> Cities { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Country Armenia = new Country
            {
                Id = 1,
                Name = "Armenia",
                Population = 3000000,
                Capital = "Yerevan",
                Area = 29.743,
                Language = "Armenian",
                Religion = "Christianity",
                LargestCity = "Yerevan",
            };

            City c1 = new City { Id = 1,Name = "Yerevan",CountryId = Armenia.Id };
            City c2 = new City {Id=2, Name = "Gyumri" , CountryId = 1 };
            City c3 = new City {Id=3, Name = "Vanadzor" , CountryId = 1 };
            modelBuilder.Entity<Country>().HasData(Armenia);
           
        }
    }
}
