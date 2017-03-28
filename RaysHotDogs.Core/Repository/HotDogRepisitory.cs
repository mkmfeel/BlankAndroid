using System.Collections.Generic;
using System.Linq;
using RaysHotDogs.Core.Model;

namespace RaysHotDogs.Core.Repository
{
    public class HotDogRepisitory
    {
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>
        {
            new HotDogGroup
            {
                HotDogGroupId = 1,
                Title = "Meet lovers",
                ImagePath = "",
                HotDogs = new List<HotDog>
                {
                    new HotDog
                    {
                        HotDogId = 1,
                        Name = "Regular Hot Dog",
                        ShortDescription = "The best there is on planet",
                        Description = "Long description 1 bla bla bla 1",
                        ImagePath = "hotdog1",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string> {"Regular bun", "Sausage", "Ketchup"},
                        Price = 8,
                        IsFaivorite = true
                    },
                    new HotDog
                    {
                        HotDogId = 2,
                        Name = "Haute Dog",
                        ShortDescription = "The classy one",
                        Description = "Long description 2 bla bla bla 2",
                        ImagePath = "hotdog2",
                        Available = true,
                        PrepTime = 15,
                        Ingredients = new List<string> {"Backet bun", "Gourmet sausage", "Ketchup"},
                        Price = 10,
                        IsFaivorite = false
                    },
                    new HotDog
                    {
                        HotDogId = 3,
                        Name = "Extra Long",
                        ShortDescription = "For when a regular one is'nt enough",
                        Description = "Long description 3 bla bla bla 3",
                        ImagePath = "hotdog3",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string> {"Extra long bun", "Extra long sausage", "Ketchup"},
                        Price = 8,
                        IsFaivorite = true
                    }
                }
            },
            new HotDogGroup
            {
                HotDogGroupId = 2,
                Title = "Veggie lovers",
                ImagePath = "",
                HotDogs = new List<HotDog>
                {
                    new HotDog
                    {
                        HotDogId = 4,
                        Name = "Veggie Hot Dog",
                        ShortDescription = "American for non-meet-lovers",
                        Description = "Long description 4 bla bla bla 4",
                        ImagePath = "hotdog4",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string> {"Bun", "Vegetarian sausage", "Ketchup"},
                        Price = 8,
                        IsFaivorite = false
                    },
                    new HotDog
                    {
                        HotDogId = 5,
                        Name = "Haute Dog Veggie",
                        ShortDescription = "Classy and veggie",
                        Description = "Long description 5 bla bla bla 5",
                        ImagePath = "hotdog5",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string> {"Backed bun", "Gourmet vegetarian sausage", "Ketchup"},
                        Price = 8,
                        IsFaivorite = false
                    },
                    new HotDog
                    {
                        HotDogId = 6,
                        Name = "Extra long Veggie",
                        ShortDescription = "For when a regular one is'nt enough",
                        Description = "Long description 6 bla bla bla 6",
                        ImagePath = "hotdog6",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string> {"Extra long bun", "Extra vegetarian sausage", "Ketchup"},
                        Price = 8,
                        IsFaivorite = false
                    }
                }
            }
        };

        public List<HotDog> GetAllHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs

                select hotDog;

            return hotDogs.ToList();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.HotDogId == hotDogId
                select hotDog;

            return hotDogs.FirstOrDefault();
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogGroups;
        }

        public List<HotDog> GetHotDogsForGroups(int groupId)
        {
            var group = hotDogGroups.FirstOrDefault(x => x.HotDogGroupId == groupId);

            return group?.HotDogs;
        }

        public List<HotDog> GetFavoritesHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.IsFaivorite
                select hotDog;

            return hotDogs.ToList();
        }
    }
}