using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Patterns
{
    interface Pénztár
    {
        int Visszaad(int forint);
        double Visszaad(double euro);
    }

    class TescoPénztár : Pénztár
    {
        public int Visszaad(int forint)
        {
            return 100;
        }

        public double Visszaad(double euro)
        {
            return 10.0;
        }
    }

    // Változékony metódus kódja
    interface IHápogás
    {
        void Hápog();
    }

    // Konkrét stratégia
    class NémaHápogás : IHápogás
    {
        public void Hápog()
        {
            Console.WriteLine("...");
        }
    }
    // Konkrét stratégia
    class DonaldHápogás : IHápogás
    {
        public void Hápog()
        {
            Console.WriteLine("fhkdfjvsnjjbodsgjbk");
        }
    }
    // Konkrét Stratégia
    class NormálHápogás : IHápogás
    {
        public void Hápog()
        {
            Console.WriteLine("quack-quack");
        }
    }

    // Az osztályunk
    class Katscha
    {
        IHápogás hápogás; // Objektum-összetétel
        public Katscha(IHápogás hápogás)
        {
            this.hápogás = hápogás; // Felelősség injektálása
        }

        public void Hápog()
        {
            hápogás.Hápog(); // Felelősség átadása a stratégiának - delegáció
        }
    }
}
