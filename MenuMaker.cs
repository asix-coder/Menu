using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayonnnaise", "relish", "french dressing" };
        string[] Breads = { "rice bread", "white bread", "wheat bread", "pumpernickel", "italian bread", "a roll" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + ", " + randomCondiment + ", " + randomBread;
        }

    }
}
