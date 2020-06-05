using System;
using System.Collections.Generic;

namespace IronNinja.Models
{
    public class Buffet
    {
        public List<IConsumable> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
            new Food("apple", 250, false, false),
            new Food("banana", 400, true, false),
            new Food("cherry", 50, true, false),
            new Food("grape", 75, false, true),
            new Food("peach", 150, false, true),
            new Food("orange", 100, true, true),
            new Food("mango", 600, false, false),
            new Drink("water", 0),
            new Drink("tea", 25),
            new Drink("soda", 50),
            };
        }

        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}