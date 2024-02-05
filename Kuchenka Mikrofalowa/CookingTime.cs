using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchenka_Mikrofalowa
{
    class CookingTime
    {
        private int _czasGotowania;

        public void Set()
        {
            Console.WriteLine("Ustawianie czasu gotowania:");
            Console.WriteLine("Wprowadź czas gotowania w minutach:");

            while (!int.TryParse(Console.ReadLine(), out _czasGotowania) || _czasGotowania < 0)
            {
                Console.WriteLine("Nieprawidłowa wartość. Wprowadź czas gotowania w minutach:");
            }

            SaveToFile("CookingTime", _czasGotowania.ToString());
        }

        private void SaveToFile(string key, string value)
        {
            using (StreamWriter sw = new StreamWriter("microwaveSettings.txt", true))
            {
                sw.WriteLine($"{key}={value}");
            }
        }
    }
}
