using _11_Events_Home_Work;

internal class Program
{
    private static void Main(string[] args)
    {
        HotHouse house = new HotHouse();
        house.Temperature = 20;

        Heater heater = new Heater { Name = "Teplomax" };
        Cooler cooler = new Cooler { Name = "Aqualine" };

        house.TooCold += heater.Warm;
        house.TooHot += cooler.Cool;

        house.Well += heater.Stop;
        house.Well += cooler.Stop;

        Random rnd = new Random();

        Console.Write("press ANY KEY to simulate weather temperature change or  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("press ESC to exit");
        Console.ResetColor();
        Console.WriteLine();


        while (true)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)
                break;

            int delta = rnd.Next(-5, 5); // // випадкова зміна температури для погоди
            house.ChangeByWeather(delta); // погода почала а сетер сам все повикликає
            Console.WriteLine();
            Console.Write("press ANY KEY to simulate weather temperature change or  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("press ESC to exit");
            Console.ResetColor();
            Console.WriteLine();
        }

        Console.WriteLine("\tFINISH");
    }
}