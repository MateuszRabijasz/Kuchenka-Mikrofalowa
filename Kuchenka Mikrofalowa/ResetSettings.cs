using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchenka_Mikrofalowa
{
    class ResetSettings
    {
        private string _plik = "microwaveSettings.txt";

        public void Reset()
        {
            File.Create(_plik).Close();
            Console.WriteLine("Ustawienia zostały zresetowane.");
        }
    }
}
