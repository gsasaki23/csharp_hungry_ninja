using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Ninja
    {
        // Fields
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // "Getter" that returns true if Ninja has taken 1200 calories and is full
        public bool IsFull 
        {
            get
            {
                return calorieIntake > 1200;
            }
        }

        // Constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        
        // Issue a warning if ninja is full, otherwise eat
        public void Eat(Food item)
        {
            if (!IsFull){
                // adds calorie value to ninja's total calorieIntake
                calorieIntake += item.Calories;

                // adds the randomly selected Food object to ninja's FoodHistory list
                FoodHistory.Add(item);

                // writes the Food's Name - and if it is spicy/sweet to the console
                string flavorStr;
                if (item.IsSpicy && item.IsSweet) flavorStr = "Sweet and Spicy";
                else if (item.IsSpicy && !item.IsSweet) flavorStr = "Spicy";
                else if (!item.IsSpicy && item.IsSweet) flavorStr = "Sweet";
                else flavorStr = "Tasteless";

                Console.WriteLine($"Ate some {flavorStr} {item.Name}.");
            }
            else{
                Console.WriteLine("The ninja is full and cannot eat anymore...");
                return;
            }
        }
    }
}