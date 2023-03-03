using SeedCatalogClassLibrary.Interfaces;
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

        public void CreateDetails(string categoryName)
        {
            List<FlowerModel> flowers = new List<FlowerModel>();
            string response;

            Console.Write($"Add flower to {categoryName} category? Type 'Yes' or 'No': ");
            response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                do
                {
                    FlowerModel flower = new FlowerModel();

                    Console.Write("Name: ");
                    flower.Name = Console.ReadLine();

                    Console.Write("Description: ");
                    flower.Description = Console.ReadLine();

                    Console.Write("Genus: ");
                    flower.Genus = Console.ReadLine();

                    Console.Write("Species: ");
                    flower.Species = Console.ReadLine();

                    Console.Write("Light Requirements (ie: Full Sun, Partial Sun, Shade, etc.): ");
                    flower.LightRequirements = Console.ReadLine();

                    Console.Write("Zone: (6a, 6b, 8a, 10b etc.) ");
                    flower.Zone = Console.ReadLine();

                    Console.Write("Instructions: ");
                    flower.Instructions = Console.ReadLine();

                    Console.Write("Images: ");
                    flower.Images = Console.ReadLine();

                    flowers.Add(flower);

                    Console.Write($"Add another flower to {categoryName} category? Type 'Yes' or 'No': ");
                    response = Console.ReadLine();
                    Console.WriteLine(); // Spacing purposes

                } while (response.ToLower() != "no");
            }
        }
    }
}
