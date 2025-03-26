using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Patterns
{
    internal class EagerSingleton
    {
        // Osztályszintű, mivel el kell érnem példányosítás nélkül :)
        // Mivel mohó, ezért rögtön a program lefutásakor rögtön példányosítjuk
        private static EagerSingleton instance = new EagerSingleton();
        // Biztonságos elérés
        public static EagerSingleton Instance
        {
            get
            {
                // Visszaadom
                return instance;
            }
        }

        // Priváttá tesszük, mert nem szeretnénk, hogy mások példányosítsák
        // Ha lennének mezőink, itt kezdő értéket adunk nekik
        private EagerSingleton()
        {

        }
    }
}
