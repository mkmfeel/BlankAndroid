using System.Collections.Generic;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Repository;

namespace RaysHotDogs.Core.Service
{
    public class HotDogDataService
    {
        private static HotDogRepisitory hotDogRepisitory = new HotDogRepisitory();

        public List<HotDog> GetAllHotDogs()
        {
            return hotDogRepisitory.GetAllHotDogs();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            return hotDogRepisitory.GetHotDogById(hotDogId);
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogRepisitory.GetGroupedHotDogs();
        }

        public List<HotDog> GetHotDogsForGroups(int groupId)
        {
            return hotDogRepisitory.GetHotDogsForGroups(groupId);
        }

        public List<HotDog> GetFavoritesHotDogs()
        {
            return hotDogRepisitory.GetFavoritesHotDogs();
        }
    }
}