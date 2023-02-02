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
            string vendorsName = string.Empty;
            string plantType = string.Empty;
            string vegetableCategoryName = string.Empty;
            string flowerCategoryName = string.Empty;

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

                            Console.WriteLine($"Please select a category name below at which your vegetable seed belongs to: ");
                            Console.WriteLine();

                            // Loop through Vegetable Categories and display on screen
                            foreach (string vegetableCategories in Enum.GetNames(typeof(VegetableCategories)))
                            {                            
                                Console.WriteLine($"{vegetableCategories}");
                            }

                            Console.WriteLine();
                            vegetableCategoryName = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("==========================");
                            Console.WriteLine();
                        } 
                    }
                }
                
                // Add vendor to a list of vendors
                vendors.Add(vendor);

            } while (vendorsName.ToLower() != "exit");
        }
    }
}
