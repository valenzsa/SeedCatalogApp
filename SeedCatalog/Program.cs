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
                    Console.Write("Select the Plant Type (Flowers or Vegetables): ");
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
                                    if (vegetableCategoryName.ToLower() == vegetableCategories.ToLower())
                                    {
                                        Console.WriteLine($"{vegetableCategoryName} is EQUAL TO {vegetableCategories}");
                                        isSelectedCategoryNameMatched = true;
                                        CreateVegetableDetails();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{vegetableCategoryName} is NOT EQUAL TO {vegetableCategories}");

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

        public static void CreateVegetableDetails()
        {
            List<VegetableModel> vegetables = new List<VegetableModel>();
            string vegetableName;
            bool IsANumber;

            do
            {
                VegetableModel vegetable = new VegetableModel();
                Console.WriteLine("Name: ");
                vegetableName = Console.ReadLine();
                vegetable.Name = vegetableName;

                Console.WriteLine("Description: ");
                vegetable.Description = Console.ReadLine();

                Console.WriteLine("Genus: ");
                vegetable.Genus = Console.ReadLine();

                Console.WriteLine("Species: ");
                vegetable.Species = Console.ReadLine();

                Console.WriteLine("Light Requirements (ie: Full Sun, Partial Sun, Shade, etc.");
                vegetable.LightRequirements = Console.ReadLine();

                Console.WriteLine("Zone: ");
                vegetable.Zone = Console.ReadLine();

                Console.WriteLine("Instructions: ");
                vegetable.Instructions = Console.ReadLine();

                Console.WriteLine("Images: ");
                vegetable.Images = Console.ReadLine();

                Console.WriteLine("Seed Type: ");
                vegetable.SeedType = Console.ReadLine();

                Console.WriteLine("Fruit Color: ");
                vegetable.FruitColor = Console.ReadLine();


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


            } while (vegetableName.ToLower() != "exit");
        }
    }
}
