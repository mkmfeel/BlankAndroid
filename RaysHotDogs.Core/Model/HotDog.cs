﻿using System.Collections.Generic;

namespace RaysHotDogs.Core.Model
{
    public class HotDog
    {
        public int HotDogId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public int Price { get; set; }

        public bool Available { get; set; }

        public int PrepTime { get; set; }

        public List<string> Ingredients { get; set; }

        public bool IsFaivorite { get; set; }

        public string GroupName { get; set; }
    }
}