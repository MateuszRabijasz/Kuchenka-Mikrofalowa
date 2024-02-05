using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchenka_Mikrofalowa
{
    class CookingPower
    {
        private int _mocMikrofali;

        public void Set()
        {
            Console.WriteLine("Ustawianie mocy gotowania:");
            Console.WriteLine("Wprowadź moc gotowania (np. 1-10):");

            while (!int.TryParse(Console.ReadLine(), out _mocMikrofali) || _mocMikrofali < 1 || _mocMikrofali > 10)
            {
                Console.WriteLine("Nieprawidłowa wartość. Wprowadź moc gotowania (1-10):");
            }

            SaveToFile("CookingPower", _mocMikrofali.ToString());
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
