using System;
using IronNinja.Models;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet MyBuffet = new Buffet();
            SpiceHound SpiceNinja = new SpiceHound();
            SweetTooth SweetNinja = new SweetTooth();

            Console.WriteLine(SpiceNinja.IsFull);
            Console.WriteLine(SweetNinja.IsFull);

            while(!SpiceNinja.IsFull || !SweetNinja.IsFull)
            {
                SpiceNinja.Consume(MyBuffet.Serve());
                SweetNinja.Consume(MyBuffet.Serve());
            }
            
            if(SpiceNinja.ConsumptionHistory.Count > SweetNinja.ConsumptionHistory.Count)
            {
                Console.WriteLine("SpiceNinja has won!");
                Console.WriteLine($"SpiceNinja ate {SpiceNinja.ConsumptionHistory.Count} items");
            }
            else
            {
                Console.WriteLine("SweetNinja has won!");
                Console.WriteLine($"SweetNinja ate {SweetNinja.ConsumptionHistory.Count} items");
            }
        }
    }
}
