using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Events_Home_Work
{
    class Heater // subscriber
    {
        public string Name { get; set; }

        public void Warm(HotHouse h)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Heater {Name} increases temperature by 5°C");
            Console.ResetColor();
            h.Temperature += 5;
        }

        public void Stop(HotHouse h)
        {
            Console.WriteLine($"Heater {Name} is OFF "); // якщо подія Well — "пристрій вимикається"
        }
    }
}
