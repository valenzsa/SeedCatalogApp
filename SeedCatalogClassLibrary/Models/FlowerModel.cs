﻿using SeedCatalogClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedCatalogClassLibrary.Models
{
    public class FlowerModel : IDetails
    {
        public string BloomColor { get; set; }
        public string FoliageColor { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Genus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Species { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LightRequirements { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Zone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Instructions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool hasImages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Images { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
