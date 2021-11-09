using gilded_roseTP.models;
using System;
using System.Collections.Generic;

namespace gilded_roseTP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<element> el = new List<element>();
            UpdateQuality(el);
        }

        public static void UpdateItemQuality(element element)
        {
            if (element.type == "sulfuras")
            {
                return;
            }
            if (element.type == "aged Bire" || element.type == "backstage passes")
            {
                element.quality++;
                if (element.type == "backstage passes" && element.sellIn < 10)
                {
                    element.quality += 2;
                }
                if (element.type == "backstage passes" && element.sellIn < 5)
                {
                    element.quality += 3;
                }
                if (element.type == "backstage passes" && element.sellIn < 0)
                {
                    element.quality = 0;
                }
            }
            else
            {
                UpdateGenericQuality(element);
            }
        }

        public static void UpdateGenericQuality(element element)
        {
            element.sellIn--;
            element.quality--;
        }

        public static void KeepQualityInRange(element element)
        {
            if (element.quality > 50)
            {
                element.quality = 50;
            }
            if (element.quality < 0)
            {
                element.quality = 0;
            }
        }
        public static void UpdateQuality (List<element> element)
        {
            foreach(element el in element)
            {
                UpdateItemQuality(el);
                KeepQualityInRange(el);
            }
        }
    }
}
