using Microsoft.EntityFrameworkCore;

namespace CountriesAPI.Models
{
    public class CountryDbContext : DbContext
    {
       public CountryDbContext (DbContextOptions<CountryDbContext> options):base(options) { }

        public DbSet<Country> Countries { get; set;}
        public DbSet<City> Cities { get; set;}
    }
}
