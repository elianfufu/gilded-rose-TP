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
            Console.WriteLine(el.sellIn);
        }
        public static void UpdateQuality (element element)
        {
            element.sellIn -= 1;
            element.quality -= 1;
            if (element.sellIn < 0)
            {
                element.quality -= 2;
            }

            if (element.quality < 0)
            {
                element.quality = 0;
            }

            if (element.type == "aged Bire")
            {
                element.quality += 1;
            }

            if (element.quality > 50)
            {
                element.quality = 50;
            }

            if (element.type == "sulfuras")
            {
                element.sellIn = element.sellIn;
                element.quality = element.quality;
            }


        }
    }
}
