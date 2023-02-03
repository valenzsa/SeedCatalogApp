using SeedCatalogClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedCatalogClassLibrary.Models
{
    public class VegetableModel : IDetails
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        public string LightRequirements { get; set; }
        public string Zone { get; set; }
        public string Instructions { get; set; }
        public bool hasImages { get; set; }
        public string Images { get; set; }
        public string SeedType { get; set; }
        public string FruitColor { get; set; }
        public int DaysToMature { get; set; }
    }
}
