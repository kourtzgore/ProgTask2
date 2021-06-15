using System.Collections.Generic;
using System.Data.Entity;

namespace ProgTask2.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Pets"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Equiptment"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Accessories"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Gardening"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Miscellaneous"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Cat Bowl",
                    Description = "Super cute cat shaped bowl for your little cat shaped friend.",
                    ImagePath="image1.png",
                    UnitPrice = 50.00,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Dog Collor",
                    Description = "Fancy leather collor so that you don't lose your doggo.",
                    ImagePath="image2.png",
                    UnitPrice = 100.00,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Pet bed",
                    Description = "Sheep skin pet bed perfect for kneeding and scratching.",
                    ImagePath="image3.png",
                    UnitPrice = 200.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Pet tent",
                    Description = "Pet bed suitable for camping",
                    ImagePath="image4.png",
                    UnitPrice = 249.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Chewy pet toys",
                    Description = "Assortment of chew toys including 2 balls and a bone." +
                                  "No batteries required.",
                    ImagePath="image5.png",
                    UnitPrice = 45.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Spade",
                    Description = "Dig up anything and everything.",
                    ImagePath="image6.png",
                    UnitPrice = 100.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Hosepipe",
                    Description = "Water your plants or clean your car.",
                    ImagePath="image7.png",
                    UnitPrice = 145.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Hosepipe attachment",
                    Description = "Create rainbows with the use of this.",
                    ImagePath="image8.png",
                    UnitPrice = 70.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Garden Fork",
                    Description = "Knife not included.",
                    ImagePath="image9.png",
                    UnitPrice = 100.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Gloves",
                    Description = "Keep your hands clean and stylish with these floral print gloves.",
                    ImagePath="image10.png",
                    UnitPrice = 150.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Goggles",
                    Description = "Look like a scientist.",
                    ImagePath="image11.png",
                    UnitPrice = 90.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Spray bottle",
                    Description = "Pink and pretty.",
                    ImagePath="image12.png",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Pot",
                    Description = "Perfect for herbs, small flowers and succulants",
                    ImagePath="image13.png",
                    UnitPrice = 100.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Potting mix",
                    Description = "Perfect for pots.",
                    ImagePath="image14.png",
                    UnitPrice = 60.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Rose starter",
                    Description = "Perfect for potting mix.",
                    ImagePath="image15.png",
                    UnitPrice = 30.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Candle",
                    Description = "Loadshedding essential.",
                    ImagePath="image16.png",
                    UnitPrice = 19.95,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}