using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Patterns
{
    internal class LazySingleton
    {
        // Osztályszintű, mivel el kell érnem példányosítás nélkül
        private static LazySingleton instance;
        // Biztonságos elérés
        public static LazySingleton Instance
        {
            get
            {
                // Lustaság fél egészség - csak akkor jöjjön létre, ha kíváncsiak rá
                if (instance == null)
                {
                    // Létrehozom
                    instance = new LazySingleton();
                }
                // Visszaadom
                return instance;

            }
        }

        // Priváttá tesszük, mert nem szeretnénk, hogy mások példányosítsák
        // Ha lennének mezőink, itt kezdő értéket adunk nekik
        private LazySingleton()
        {

        }
    }
}
