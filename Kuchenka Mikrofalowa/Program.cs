using Kuchenka_Mikrofalowa;
using System;
using System.IO;

class MicrowaveApp
{
    static void Main()
    {
        {
            CookingTime cookingTime = new CookingTime();
            CookingPower cookingPower = new CookingPower();
            ResetSettings resetSettings = new ResetSettings();
            DishType dishType = new DishType();
            ShowSettings showSettings = new ShowSettings();
            Cook cook = new Cook();
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.Clear();
                Console.WriteLine("Witaj w programie kuchenki mikrofalowej!");
                Console.WriteLine("1. Wybierz typ potrawy");
                Console.WriteLine("2. Ustaw czas gotowania");
                Console.WriteLine("3. Ustaw moc gotowania");
                Console.WriteLine("4. Pokaż ustawienia w pamięci");
                Console.WriteLine("5. Gotuj");
                Console.WriteLine("6. Wyczyść Plik z Ustawieniami");
                Console.WriteLine("7. Wyjście");

                Console.Write("\nWybierz opcję: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        dishType.Choose();
                        break;
                    case "2":
                        cookingTime.Set();
                        break;
                    case "3":
                        cookingPower.Set();
                        break;
                    case "4":
                        showSettings.Show();
                        break;
                    case "5":
                        cook.Start();
                        break;
                    case "6":
                        resetSettings.Reset();
                        break;
                    case "7":
                        exitProgram = true;
                        break;

                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }

                if (!exitProgram)
                {
                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                    Console.ReadKey();
                }
            }
        }
    }
}
