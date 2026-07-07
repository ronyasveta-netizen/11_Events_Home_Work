using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Events_Home_Work
{
    class Cooler // subscriber
    {
        public string Name { get; set; }

        public void Cool(HotHouse house)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Cooler {Name} decreases temperature by 5°C ");
            Console.ResetColor();
            house.Temperature -= 5;
        }

        public void Stop(HotHouse house)
        {
            Console.WriteLine($"Cooler {Name} is OFF ");  // якщо подія Well — "пристрій вимикається"
        }
    }
}
