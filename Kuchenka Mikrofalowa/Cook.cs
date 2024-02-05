using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchenka_Mikrofalowa
{
    class Cook
    {
        private ShowSettings _showSettings = new ShowSettings();

        public void Start()
        {
            Dictionary<string, string> settings = _showSettings.LoadSettings();
            _showSettings.Show();

            string dishType = settings.ContainsKey("DishType") ? settings["DishType"] : "Unknown";
            int CzasGotowania = settings.ContainsKey("CookingTime") ? int.Parse(settings["CookingTime"]) : 0;
            int MocMikrofali = settings.ContainsKey("CookingPower") ? int.Parse(settings["CookingPower"]) : 0;
            switch (dishType)
            {
                case "Microwave":
                    if (MocMikrofali < 5)
                    {
                        if (MocMikrofali > 2)
                        {
                            if (CzasGotowania > 1 && CzasGotowania < 5)
                            {
                                Console.WriteLine("Potrawa ugotowana w mikrofali *BEEP* *BEEP* *BEEP*");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Potrawa spalona w mikrofali - zbyt długo się gotowała *BEEP* *BEEP* *BEEP*");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Potrawa niepodgrzana w mikrofali - za mała moc *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Potrawa przypalona w mikrofali - zbyt wielka moc!! *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                case "Grill":
                    if (MocMikrofali < 6)
                    {
                        Console.WriteLine("Potrawa nieugrillowana - zbyt mała moc *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                    if (MocMikrofali < 10)
                    {
                        if (CzasGotowania > 3 && CzasGotowania < 12)
                        {
                            Console.WriteLine("Potrawa ugrillowana *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Pożar na grillu - potrawa zbyt długo się grillowała *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Błędny zapis pliku!!! Zbyt wielka moc!! *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                case "Combi":
                    if (MocMikrofali < 5)
                    {
                        Console.WriteLine("Potrawa surowa - zbyt mała moc *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                    if (MocMikrofali < 8)
                    {
                        if (CzasGotowania > 2 && CzasGotowania < 10)
                        {
                            Console.WriteLine("Potrawa przygotowana w trybie Combi *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Potrawa spalona w trybie Combi - zbyt długo się gotowała *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Potrawa przypalona w trybie Combi - zbyt wielka moc!! *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                case "Defrost":
                    if (MocMikrofali < 4)
                    {
                        if (CzasGotowania > 1 && CzasGotowania < 7)
                        {
                            Console.WriteLine("Potrawa rozmrożona *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Potrawa nadmiernie rozmrożona w trybie Defrost *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Potrawa zniszczona w trybie Defrost - zbyt wielka moc!! *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                case "Warm":
                    if (MocMikrofali < 3)
                    {
                        if (CzasGotowania > 1 && CzasGotowania < 8)
                        {
                            Console.WriteLine("Potrawa podgrzana *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Potrawa przegrzana w trybie Podgrzewania *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Potrawa przypalona w trybie Podgrzewania - zbyt wielka moc!! *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                case "Soft/Melt":
                    if (MocMikrofali < 2)
                    {
                        if (CzasGotowania > 1 && CzasGotowania < 5)
                        {
                            Console.WriteLine("Potrawa rozmiękła/roztopiła się *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Potrawa spalona w trybie Soft/Melt *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Potrawa zniszczona w trybie Soft/Melt - zbyt wielka moc!! *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                case "Steam/Boil":
                    if (MocMikrofali < 3)
                    {
                        Console.WriteLine("Potrawa nieugotowana - zbyt mała moc na parę *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                    if (MocMikrofali < 7)
                    {
                        if (CzasGotowania > 3 && CzasGotowania < 15)
                        {
                            Console.WriteLine("Potrawa ugotowana na parze/wrzątku *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Potrawa przegotowana w trybie Steam/Boil *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Potrawa zniszczona w trybie Steam/Boil - zbyt wielka moc!! *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                case "Auto Cook":
                    if (MocMikrofali < 3)
                    {
                        Console.WriteLine("Potrawa niedogotowana - zbyt mała moc *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                    if (MocMikrofali < 6)
                    {
                        if (CzasGotowania > 2 && CzasGotowania < 12)
                        {
                            Console.WriteLine("Potrawa ugotowana w trybie Auto Cook *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Potrawa przegotowana w trybie Auto Cook *BEEP* *BEEP* *BEEP*");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Potrawa zniszczona w trybie Auto Cook - zbyt wielka moc!! *BEEP* *BEEP* *BEEP*");
                        break;
                    }
                default:
                    Console.WriteLine("Nieznany tryb gotowania.");
                    break;
            }
            }
    }
}
