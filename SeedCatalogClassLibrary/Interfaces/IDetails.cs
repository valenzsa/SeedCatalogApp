using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedCatalogClassLibrary.Interfaces
{
    public interface IDetails
    {
        string Name { get; set; }
        string Description { get; set; }
        string Genus { get; set; }
        string Species { get; set; }
        string LightRequirements { get; set; }
        string Zone { get; set; }
        string Instructions { get; set; }
        bool hasImages { get; set; }
        string Images { get; set; }
    }
}
