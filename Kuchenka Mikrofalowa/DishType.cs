using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchenka_Mikrofalowa
{
    class DishType
    {
        private string? _typ;

        public void Choose()
        {
            Console.WriteLine("Okej wybierz teraz tryb gotowania!:");
            Console.WriteLine("1. Microwave");
            Console.WriteLine("2. Grill");
            Console.WriteLine("3. Combi");
            Console.WriteLine("4. Defrost");
            Console.WriteLine("5. Warm");
            Console.WriteLine("6. Soft/Melt");
            Console.WriteLine("7. Steam/Boil");
            Console.WriteLine("8. Auto Cook");

            Console.Write("\nWybierz opcję: ");
            _typ = Console.ReadLine();

            switch (_typ)
            {
                case "1":
                    SaveToFile("DishType", "Microwave");
                    break;
                case "2":
                    SaveToFile("DishType", "Grill");
                    break;
                case "3":
                    SaveToFile("DishType", "Combi");
                    break;
                case "4":
                    SaveToFile("DishType", "Defrost");
                    break;
                case "5":
                    SaveToFile("DishType", "Warm");
                    break;
                case "6":
                    SaveToFile("DishType", "Soft/Melt");
                    break;
                case "7":
                    SaveToFile("DishType", "Steam/Boil");
                    break;
                case "8":
                    SaveToFile("DishType", "Auto Cook");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }
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
