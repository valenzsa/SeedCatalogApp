using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeedCatalogClassLibrary.Enums.Enums;

namespace SeedCatalogClassLibrary.Models
{
    public class VendorsModel
    {
        public string VendorsName { get; set; }
        public string VendorsWebsiteURL { get; set; }
        public List<PlantTypes> PlantType { get; set; }
    }
}
