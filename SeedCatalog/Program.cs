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

            Console.ReadLine(); // Spacing purposes
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my Seed Catalog");
            Console.WriteLine("==========================");
            Console.WriteLine(); // Spacing purposes
        }

        public static void CreateVendor()
        {
            List<VendorsModel> vendors = new List<VendorsModel>();
            string vendorsName;
            string plantType;
            string categoryName;
            bool isSelectedCategoryNameMatched = false;

            do
            {
                VendorsModel vendor = new VendorsModel();

                Console.Write("What is the Vendor's Name? ");
                vendorsName = Console.ReadLine();
                vendor.VendorsName = vendorsName;
                Console.WriteLine(); // Spacing purposes

                Console.Write("What is the Vendor's Website URL? ");
                vendor.VendorsWebsiteURL = Console.ReadLine();
                Console.WriteLine(); // Spacing purposes

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
                            FlowerModel flower = new FlowerModel();

                            Console.WriteLine(); // Spacing purposes
                            Console.WriteLine($"You have selected {planttype}");
                            Console.WriteLine(); // Spacing purposes

                            // Checking if typed category name matches the category in the list
                            do
                            {
                                Console.WriteLine($"Please select a category name below at which your vegetable seed belongs to: (or type 'Exit' to start over) ");
                                Console.WriteLine(); // Spacing purposes

                                // Loop through Vegetable Categories and display on screen
                                foreach (string flowerCategoriesList in Enum.GetNames(typeof(FlowerCategories)))
                                {
                                    Console.WriteLine($"{flowerCategoriesList}");
                                }

                                Console.WriteLine(); // Spacing purposes
                                categoryName = Console.ReadLine();
                                Console.WriteLine(); // Spacing purposes

                                // Loop through Vegetable Categories and display on screen
                                foreach (string flowerCategories in Enum.GetNames(typeof(FlowerCategories)))
                                {
                                    // Checks if selected vegetable name exists in the list of vegetable categories.
                                    if (categoryName.ToLower() == flowerCategories.ToLower())
                                    {
                                        //Console.WriteLine($"{vegetableCategoryName} is EQUAL TO {vegetableCategories}");
                                        isSelectedCategoryNameMatched = true;
                                        //CreateDetails(categoryName);

                                        flower.CreateDetails(categoryName);
                                    }
                                    else
                                    {
                                        //Console.WriteLine($"{vegetableCategoryName} is NOT EQUAL TO {vegetableCategories}");

                                        isSelectedCategoryNameMatched = false;
                                    }
                                }
                            } while (isSelectedCategoryNameMatched != true && categoryName.ToLower() != "exit");

                            Console.WriteLine("==========================");
                            Console.WriteLine(); // Spacing purposes



                        } else if(planttype.ToLower() == "vegetables")
                        {
                            VegetableModel vegetable = new VegetableModel();

                            Console.WriteLine(); // Spacing purposes
                            Console.WriteLine($"You have selected {planttype}");
                            Console.WriteLine(); // Spacing purposes

                            // Checking if typed category name matches the category in the list
                            do
                            {
                                Console.WriteLine($"Please select a category name below at which your vegetable seed belongs to: (or type 'Exit' to start over) ");
                                Console.WriteLine(); // Spacing purposes

                                // Loop through Vegetable Categories and display on screen
                                foreach (string vegetableCategoriesList in Enum.GetNames(typeof(VegetableCategories)))
                                {
                                    Console.WriteLine($"{vegetableCategoriesList}");
                                }

                                Console.WriteLine(); // Spacing purposes
                                categoryName = Console.ReadLine();
                                Console.WriteLine(); // Spacing purposes

                                // Loop through Vegetable Categories and display on screen
                                foreach (string vegetableCategories in Enum.GetNames(typeof(VegetableCategories)))
                                {
                                    // Checks if selected vegetable name exists in the list of vegetable categories.
                                    if (categoryName.ToLower() == vegetableCategories.ToLower())
                                    {
                                        //Console.WriteLine($"{vegetableCategoryName} is EQUAL TO {vegetableCategories}");
                                        isSelectedCategoryNameMatched = true;
                                        //CreateDetails(categoryName);
                                        
                                        vegetable.CreateDetails(categoryName);
                                    }
                                    else
                                    {
                                        //Console.WriteLine($"{vegetableCategoryName} is NOT EQUAL TO {vegetableCategories}");

                                        isSelectedCategoryNameMatched = false;
                                    }
                                }
                            } while (isSelectedCategoryNameMatched != true && categoryName.ToLower() != "exit");
                            
                            Console.WriteLine("==========================");
                            Console.WriteLine(); // Spacing purposes
                        } 
                    }
                }
                
                // Add vendor to a list of vendors
                vendors.Add(vendor);

            } while (vendorsName.ToLower() != "exit");
        }
    }
}
