using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Restaurant
{
    public string name = "";
    public string category = "";
    public float rate = 0;

    public Restaurant(string name, string category, float rate)
    {
        this.name = name;
        this.category = category;
        this.rate = rate;
    }
}


namespace work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>({
                new Restaurant("Quanjude Roast Duck", "Beijing Cuisine", 4.5f),
                new Restaurant("Donglaishun Hot Pot", "Hot Pot", 4.6f),
                new Restaurant("Din Tai Fung", "Taiwanese Cuisine", 4.7f)

            });
        }
    }
}
