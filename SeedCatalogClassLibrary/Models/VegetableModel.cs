using SeedCatalogClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeedCatalogClassLibrary.Enums.Enums;

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
        public List<TomatoFruitSet> TomatoFruitSet { get; set; }

        public string FruitBearing { get; set; }
        public int DaysToMature { get; set; }

        public void CreateDetails(string categoryName)
        {
            List<VegetableModel> vegetables = new List<VegetableModel>();
            bool IsANumber;
            string response;

            Console.Write($"Add vegetable to {categoryName} category? Type 'Yes' or 'No': ");
            response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                do
                {
                    VegetableModel vegetable = new VegetableModel();

                    Console.Write("Name: ");
                    vegetable.Name = Console.ReadLine();

                    Console.Write("Description: ");
                    vegetable.Description = Console.ReadLine();

                    Console.Write("Genus: ");
                    vegetable.Genus = Console.ReadLine();

                    Console.Write("Species: ");
                    vegetable.Species = Console.ReadLine();

                    Console.Write("Light Requirements (ie: Full Sun, Partial Sun, Shade, etc.): ");
                    vegetable.LightRequirements = Console.ReadLine();

                    Console.Write("Zone: (6a, 6b, 8a, 10b etc.) ");
                    vegetable.Zone = Console.ReadLine();

                    Console.Write("Instructions: ");
                    vegetable.Instructions = Console.ReadLine();

                    Console.Write("Images: ");
                    vegetable.Images = Console.ReadLine();

                    Console.Write("Seed Type: ");
                    vegetable.SeedType = Console.ReadLine();

                    Console.Write("Fruit Color: (Red, Green, Yellow, Orange, etc.): ");
                    vegetable.FruitColor = Console.ReadLine();

                    // Check if vegetable category is tomatoes
                    // Decide whether its Determinate or Indeterminate
                    if (categoryName.ToLower() == "tomatoes")
                    {
                        Console.WriteLine(); // Spacing purposes
                        Console.WriteLine($"Category name is {categoryName}");
                        Console.WriteLine(); // Spacing purposes

                        Console.WriteLine($"Please select {vegetable.Name} Tomato's Fruit Set below: ");
                        Console.WriteLine(); // Spacing purposes
                        foreach (string TomatoFruitSet in Enum.GetNames(typeof(TomatoFruitSet)))
                        {
                            Console.WriteLine($"{TomatoFruitSet}");
                        }
                        Console.WriteLine(); // Spacing purposes
                        vegetable.FruitBearing = Console.ReadLine();
                    }

                    do
                    {
                        Console.WriteLine("Days To Mature: ");
                        var daysToMature = Console.ReadLine();
                        IsANumber = int.TryParse(daysToMature, out int number);

                        if (IsANumber)
                        {
                            //Console.WriteLine($"The {daysToMature} is converted to {number}");
                            vegetable.DaysToMature = number;
                        }
                        //else
                        //{
                        //    Console.WriteLine($"The {daysToMature} is not converted to a number.  Please enter a numerical number.");
                        //}
                    } while (IsANumber != true);

                    vegetables.Add(vegetable);

                    Console.Write($"Add another vegetable to {categoryName} category? Type 'Yes' or 'No': ");
                    response = Console.ReadLine();
                    Console.WriteLine(); // Spacing purposes

                } while (response.ToLower() != "no");
            }
        }
    }
}
