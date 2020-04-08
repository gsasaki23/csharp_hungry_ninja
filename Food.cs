using System;

namespace Hungry_Ninja
{
    class Food
    {
        // Fields
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        
        // Constructor that takes in all four parameters
        public Food(string givenName, int givenCalories, bool givenIsSpicy, bool givenIsSweet)
        {
            Name = givenName;
            Calories = givenCalories;
            IsSpicy = givenIsSpicy;
            IsSweet = givenIsSweet;
        }
    }
}
