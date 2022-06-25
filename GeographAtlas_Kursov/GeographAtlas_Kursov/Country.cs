using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographAtlas_Kursov
{
    public class Country
    {
        public string Name { get; set; }

        public List<string> Nations { get; set; }
        public List<Region> Regions { get; set; }
        public List<string> Monuments { get; set; }
        public List<string> MonumentsInfo { get; set; }
        public Country() { }
        public Country(string Name)
        {
            this.Name = Name;
            Nations = new List<string>();
            Regions = new List<Region>();

            Monuments = new List<string>();
            MonumentsInfo = new List<string>();
        }
        public static void AddNations(string nations)
        {

        }
    }
}



