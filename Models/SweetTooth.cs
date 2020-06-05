using System;
namespace IronNinja.Models
{
    public class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get
            {
                if (this.calorieIntake >= 1500)
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
                if (item.IsSweet)
                {
                    this.calorieIntake += item.Calories + 10;
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