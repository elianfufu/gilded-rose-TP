using gilded_roseTP.models;
using System;
using System.Collections.Generic;

namespace gilded_roseTP
{
    class Program
    {
        static void Main(string[] args)
        {
            element el = new element();
            el.sellIn = 15;
            el.quality = 15;
            el.type = "";
            UpdateQuality(el);
        }

        public static void SulfurasElement(element element)
        {
            if (element.type == "sulfuras")
            {
                element.sellIn = element.sellIn;
                element.quality = element.quality;
            }
        }

        public static void TypeElement(element element)
        {
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
                element.sellIn--;
                element.quality--;
            }
        }

        public static void QualityElement(element element)
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
        public static void UpdateQuality (element element)
        {
            SulfurasElement(element);
            TypeElement(element);
            QualityElement(element);
        }
    }
}
