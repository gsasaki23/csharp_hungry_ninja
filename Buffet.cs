using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Buffet
    {
        // Fields
        public List<Food> Menu;

        // Constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Burger", 1000, true, false),
                new Food("Sweet & Sour Chicken Wings", 800, true, true),
                new Food("Cajun Fries", 900, true, true),
                new Food("Soda", 1000, false, true),
                new Food("Salad", 200, false, false),
                new Food("Candy", 10, false, true),
                new Food("Donut", 1000, false, true)
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0,Menu.Count)];
        }
    }

}
