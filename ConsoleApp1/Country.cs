using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Country
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; } = new List<City>();

        public IEnumerable<string> FindAllByPopulation(int minPopulation, int maxPopulation)
        {
            return Cities.Where(city => city.Population >= minPopulation && city.Population <= maxPopulation)
                            .Select(city => city.Name);
        }


        
    }
}
