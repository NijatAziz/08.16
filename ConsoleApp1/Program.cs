
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Country azerbaijan = new Country
        {
            Name = "Azerbaijan",
            Cities = new List<City>
            {
                new City { Name = "Baku", Population = 2200000 },
                new City { Name = "Ganja", Population = 330000 },
                new City { Name = "Village1", Population = 8000 },
                new City { Name = "Village2", Population = 12000 }
            }
        };

        Country denmark = new Country
        {
            Name = "Denmark",
            Cities = new List<City>
            {
                new City { Name = "Copenhagen", Population = 600000 },
                new City { Name = "Aarhus", Population = 340000 },
                new City { Name = "Village3", Population = 2000 },
                new City { Name = "Village4", Population = 5000 }
            }
        };

        Country burundi = new Country
        {
            Name = "Burundi",
            Cities = new List<City>
            {
                new City { Name = "Bujumbura", Population = 800000 },
                new City { Name = "Muyinga", Population = 120000 },
                new City { Name = "Village5", Population = 1500 },
                new City { Name = "Village6", Population = 3500 }
            }
        };

        int minPopulation = 300000;
        int maxPopulation = 1000000;




        List<Country> countries = new List<Country> { azerbaijan, denmark, burundi };

        foreach (var country in countries)
        {
            IEnumerable<string> city = country.FindAllByPopulation(minPopulation, maxPopulation);
            Console.WriteLine($"{country.Name}: {string.Join(", ", city)}");
        }
    }
}

