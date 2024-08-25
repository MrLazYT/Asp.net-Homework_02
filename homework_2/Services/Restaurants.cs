using homework_2.Models;

namespace homework_2.Services
{
    public static class Restaurants
    {
        private static List<Restaurant> Items { get; set; }

        static Restaurants()
        {
            Items = new List<Restaurant>();
            SeedRestaurants();
        }
        
        public static void SeedRestaurants()
        {
            Items = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Id = 1,
                    Name="The Crimson Fork",
                    Description = "A contemporary fine dining restaurant specializing in modern fusion cuisine. The" +
                    "Crimson Fork combines traditional flavors with avant-garde techniques, offering an elegant and" +
                    "immersive dining experience. Guests can enjoy a curated menu of seasonal dishes, paired with an" +
                    "extensive selection of wines from around the world."
                },
                new Restaurant()
                {
                    Id = 2,
                    Name="Greenleaf Bistro",
                    Description = "A cozy and eco-friendly eatery focusing on farm-to-table dining. Greenleaf Bistro" +
                    "offers a variety of fresh, organic, and locally sourced dishes, with a menu that caters to" +
                    "vegetarians, vegans, and those who appreciate sustainable food practices. The restaurant's warm" +
                    "atmosphere and earthy decor make it a perfect spot for a relaxed meal."
                },
                new Restaurant()
                {
                    Id = 3,
                    Name="Seaside Grille",
                    Description = "Located right on the waterfront, Seaside Grille is a seafood lover's paradise." +
                    "This casual yet refined restaurant serves the freshest catches of the day, prepared with a" +
                    "touch of coastal flair. From grilled fish to succulent shellfish, every dish is crafted to" +
                    "highlight the natural flavors of the sea, all while guests enjoy stunning ocean views."
                },
            };
        }

        public static List<Restaurant> GetAll() => Items;

        public static Restaurant GetById(int id) => Items.FirstOrDefault(restaurant => restaurant.Id == id)!;
    }
}