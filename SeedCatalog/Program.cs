using SeedCatalogClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeedCatalogClassLibrary.Enums.Enums;

namespace SeedCatalog
{
    public class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            CreateVendor();

            Console.ReadLine();
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my Seed Catalog");
            Console.WriteLine("==========================");
            Console.WriteLine();
        }

        public static void CreateVendor()
        {
            List<VendorsModel> vendors = new List<VendorsModel>();
            string vendorsName;
            string plantType;
            string vegetableCategoryName;
            string flowerCategoryName;
            bool isSelectedCategoryNameMatched = false;

            do
            {
                VendorsModel vendor = new VendorsModel();

                Console.Write("What is the Vendor's Name? ");
                vendorsName = Console.ReadLine();
                vendor.VendorsName = vendorsName;
                Console.WriteLine();

                Console.Write("What is the Vendor's Website URL? ");
                vendor.VendorsWebsiteURL = Console.ReadLine();
                Console.WriteLine();

                do
                {
                    Console.Write("Select the Plant Type: Flowers or Vegetables? ");
                    plantType = Console.ReadLine();

                } while (plantType.ToLower() != "flowers" && plantType.ToLower() != "vegetables");
                
                
                
                // Loop through PlantTypes enums and compare with user's plant type input
                foreach(string planttype in Enum.GetNames(typeof(PlantTypes)))
                {
                    if(plantType.ToLower() == planttype.ToLower())
                    {
                        if(planttype.ToLower() == "flowers")
                        {
                            Console.WriteLine();
                            Console.WriteLine($"You have selected {planttype}");
                            Console.WriteLine();

                            Console.WriteLine($"Please select a category name below at which your flower seed belongs to: ");
                            Console.WriteLine();


                            // Loop through Vegetable Categories and display on screen
                            foreach (string flowerCategories in Enum.GetNames(typeof(FlowerCategories)))
                            {
                                Console.WriteLine($"{flowerCategories}");
                            }

                            Console.WriteLine();
                            flowerCategoryName = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("==========================");
                            Console.WriteLine();


                        } else if(planttype.ToLower() == "vegetables")
                        {
                            Console.WriteLine();
                            Console.WriteLine($"You have selected {planttype}");
                            Console.WriteLine();

                            // Checking if typed category name matches the category in the list
                            do
                            {
                                Console.WriteLine($"Please select a category name below at which your vegetable seed belongs to: ");
                                Console.WriteLine();

                                // Loop through Vegetable Categories and display on screen
                                foreach (string vegetableCategoriesList in Enum.GetNames(typeof(VegetableCategories)))
                                {
                                    Console.WriteLine($"{vegetableCategoriesList}");
                                }

                                Console.WriteLine();
                                vegetableCategoryName = Console.ReadLine();
                                Console.WriteLine();

                                // Loop through Vegetable Categories and display on screen
                                foreach (string vegetableCategories in Enum.GetNames(typeof(VegetableCategories)))
                                {
                                    // Checks if selected vegetable name exists in the list of vegetable categories.
                                    if (vegetableCategoryName.ToLower() == vegetableCategories.ToLower())
                                    {
                                        //Console.WriteLine($"{vegetableCategoryName} is EQUAL TO {vegetableCategories}");
                                        isSelectedCategoryNameMatched = true;
                                        CreateVegetableDetails(vegetableCategoryName);
                                    }
                                    else
                                    {
                                        //Console.WriteLine($"{vegetableCategoryName} is NOT EQUAL TO {vegetableCategories}");

                                        isSelectedCategoryNameMatched = false;
                                    }
                                }
                            } while (isSelectedCategoryNameMatched != true && vegetableCategoryName.ToLower() != "exit");
                            

                            

                            
                            

                            Console.WriteLine("==========================");
                            Console.WriteLine();
                        } 
                    }
                }
                
                // Add vendor to a list of vendors
                vendors.Add(vendor);

            } while (vendorsName.ToLower() != "exit");
        }

        public static void CreateVegetableDetails(string vegetableCategoryName)
        {
            List<VegetableModel> vegetables = new List<VegetableModel>();
            bool IsANumber;
            string response;

            Console.Write($"Add vegetable to {vegetableCategoryName} category? Type 'Yes' or 'No': ");
            response = Console.ReadLine();

            if(response.ToLower() == "yes")
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
                    if (vegetableCategoryName.ToLower() == "tomatoes")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Category name is {vegetableCategoryName}");
                        Console.WriteLine();

                        Console.WriteLine($"Please select {vegetable.Name} Tomato's Fruit Set below: ");
                        Console.WriteLine();
                        foreach (string TomatoFruitSet in Enum.GetNames(typeof(TomatoFruitSet)))
                        {
                            Console.WriteLine($"{TomatoFruitSet}");
                        }
                        Console.WriteLine();
                        vegetable.FruitBearing = Console.ReadLine();
                    }

                    do
                    {
                        Console.WriteLine("Days To Mature: ");
                        var daysToMature = Console.ReadLine();
                        IsANumber = int.TryParse(daysToMature, out int number);

                        if (IsANumber)
                        {
                            Console.WriteLine($"The {daysToMature} is converted to {number}");
                            vegetable.DaysToMature = number;
                        }
                        else
                        {
                            Console.WriteLine($"The {daysToMature} is not converted to a number.  Please enter a numerical number.");
                        }
                    } while (IsANumber != true);


                    vegetables.Add(vegetable);

                    Console.Write($"Add another vegetable to {vegetableCategoryName} category? Type 'Yes' or 'No': ");
                    response = Console.ReadLine();


                } while (response.ToLower() != "no");
            }
        }
    }
}
