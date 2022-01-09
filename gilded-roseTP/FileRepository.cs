using System;
using System.Collections.Generic;
using System.Reflection;
namespace gilded_roseTP
{
    class FileRepository : IInventoryRepo
    {
        // Nous n'avons pas réussi à trouver un moyen de récuperer la list d'items du projet, alors pour tout de meme avancer nous avons crée des items ci-dessous
        private IList<Item> items = new List<Item>()
        {
            new GenericItem("Generic Item", 10, 11, 15),
            new GenericItem("Generic Item", 40, 45, 46),
            new GenericItem("Generic Item", 30 , 20, 4)
        };

        public IList<Item> GetInventory()
        {
            int i = 0;
            
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\elian\Bureau\I1\Architecture applicative\EbbTechnologies\gilded-rose\items.txt");
            
            string nameITEM;
            string sellinITEM;
            string qualityITEM;
            foreach (string line in lines)
            {
                GenericItem item = new GenericItem("",0,0, 4);
                string[] subs = line.Split(',');
                // Console.WriteLine("\t" + subs);
                foreach (string sub in subs)
                {
                    
                    // Console.WriteLine($"Substring: {sub}");

                    if (i == 0)
                    {
                        nameITEM = sub;
                    }
                     
                    if (i == 1)
                    {
                        sellinITEM = sub;
                    }

                    if (i == 2)
                    {
                        qualityITEM = sub;
                    }
                    i++;
                }

                // Console.WriteLine("\t" + line);
            }

            return items;
        }

        public void SaveInventory(IList<Item> items)
        {
            
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\elian\Bureau\I1\Architecture applicative\EbbTechnologies\gilded-rose\items.txt", true))
                {
                    file.WriteLine("\t" + "Nouvelle injection" + "\t");
                    int i = 0;
                    string obj = "";
                    foreach(var item in items)
                    {
                        obj = items[i].name + ";" + items[i].sellIn + ";" + items[i].quality + ";" + items[i].value;
                        Console.WriteLine("Objet que nous ajoutons dans le fichier texte : {0}", obj);
                        file.WriteLine(obj);
                        i++;
                    }                    
                }
            }
            catch
            {
                throw new ApplicationException("Something went wrong!");
            }
        }
    }
}
