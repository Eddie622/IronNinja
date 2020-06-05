using System;

namespace IronNinja.Models
{
    public class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull
        {
            get
            {
                if(this.calorieIntake >= 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (this.IsFull)
            {
                Console.WriteLine($"{this} is full and cannot eat anymore");
            }
            else
            {
                if(item.IsSpicy)
                {
                    this.calorieIntake += item.Calories - 5;
                }
                else
                {
                    this.calorieIntake += item.Calories;
                }
                this.ConsumptionHistory.Add(item);
                Console.WriteLine($"{this} ate {item.GetInfo()}");
            }
        }
    }

}