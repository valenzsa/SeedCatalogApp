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
            Console.Write("==========================");
            Console.WriteLine();
        }

        public static void CreateVendor()
        {
            List<VendorsModel> vendors = new List<VendorsModel>();
            string vendorsName = string.Empty;
            string plantType = string.Empty;
            string vegetableCategoryName = string.Empty;

            do
            {
                VendorsModel vendor = new VendorsModel();

                Console.Write("What is the Vendor's Name? ");
                vendorsName = Console.ReadLine();
                vendor.VendorsName = vendorsName;

                Console.Write("What is the Vendor's Website URL? ");
                vendor.VendorsWebsiteURL = Console.ReadLine();

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
                            Console.WriteLine($"You have selected {planttype}");
                        } else if(planttype.ToLower() == "vegetables")
                        {
                            Console.WriteLine($"You have selected {planttype}");
                            Console.Write($"Please select a category name at which your vegetable belongs to: ");
                            vegetableCategoryName = Console.ReadLine();
                        } 
                    }
                }
                
                // Add vendor to a list of vendors
                vendors.Add(vendor);

            } while (vendorsName.ToLower() != "exit");
        }
    }
}
