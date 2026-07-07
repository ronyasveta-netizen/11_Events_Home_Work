using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Events_Home_Work
{
    
    delegate void HotHouseDeleg(HotHouse house); // наш делегат для подій теплиці

    class HotHouse // publisher
    {
        public const int MinTemp = 18;
        public const int MaxTemp = 25;

        private int _temperature; // покеруємо через властивість 
        public int Temperature 
        {
            get => _temperature;
            set
            {
                _temperature = value;
                Console.WriteLine($"Current temperature: {_temperature} °C");
                CheckTemperature(); // кожна зміна температури перевіряється і вже викличе відповідну подію 
            }
        }

        public event HotHouseDeleg TooHot;
        public event HotHouseDeleg TooCold;
        public event HotHouseDeleg Well;

        // тепер погода завжди змінює температуру
        public void ChangeByWeather(int delta)
        {
            Console.WriteLine($"Weather changes temperature by {delta} °C");
            Temperature += delta; // сетер оновить температуру, перевірить межі і викличе події
        }

        private void CheckTemperature() //  Перевірка температури та ініціювання відповідної  події
        {
            if (_temperature > MaxTemp)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!! Too hot in the hothouse !!!"); //   повідомляємо і запускаємо подію TooHot
                Console.ResetColor();
                TooHot?.Invoke(this);
            }
            else if (_temperature < MinTemp)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("!!! Too cold in the hothouse !!!"); // повідомляємо і запускаємо подію TooCold  
                Console.ResetColor();
                TooCold?.Invoke(this);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Temperature is norma"); // повідомляємо і запускаємо подію Well?
                Console.ResetColor();
                Well?.Invoke(this);
            }
        }
    }
}
