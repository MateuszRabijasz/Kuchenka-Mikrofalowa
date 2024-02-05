using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchenka_Mikrofalowa
{
    class ShowSettings
    {
        static string Plik = "microwaveSettings.txt";
        private Dictionary<string, string>? _settings;

        public Dictionary<string, string> LoadSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            if (File.Exists(Plik))
            {
                string[] lines = File.ReadAllLines(Plik);
                foreach (var line in lines)
                {
                    var parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        settings[parts[0]] = parts[1];
                    }
                }
            }
            return settings;
        }

        public void Show()
        {
            _settings = LoadSettings();

            // Sprawdzenie, czy słownik ustawień jest pusty
            bool hasDishType = _settings.ContainsKey("DishType");
            bool hasCookingTime = _settings.ContainsKey("CookingTime");
            bool hasCookingPower = _settings.ContainsKey("CookingPower");

            if (!hasDishType || !hasCookingTime || !hasCookingPower)
            {
                if (!hasDishType)
                    Console.WriteLine("Brak informacji o typie potrawy (DishType).");
                if (!hasCookingTime)
                    Console.WriteLine("Brak informacji o czasie gotowania (CookingTime).");
                if (!hasCookingPower)
                    Console.WriteLine("Brak informacji o mocy gotowania (CookingPower).");
            }
            else
            {
                Console.WriteLine($"Gotowanie: {_settings["DishType"]}");
                Console.WriteLine($"Czas: {_settings["CookingTime"]} minut");
                Console.WriteLine($"Moc: {_settings["CookingPower"]}");
            }
        }
    }
}
