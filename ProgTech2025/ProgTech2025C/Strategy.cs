using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025C
{
    // Változékony metódus kódja
    interface IUgat
    {
        void Ugat();
    }

    // Konkrét stratégia (megvalósítás)
    class VizslaUgatásStratégia : IUgat
    {
        public void Ugat()
        {
            Console.WriteLine("Vauu");
        }
    }

    // Konkrét stratégia (megvalósítás)
    class YorkiUgatásStratégia : IUgat
    {
        public void Ugat()
        {
            Console.WriteLine("VauVauVauVauVauVau");
        }
    }

    // Ősosztály, ami alkalmazza a stratégiát
    abstract class Kutya
    {
        IUgat ugat; // Objektum összetétel
        protected Kutya(IUgat ugat)
        {
            this.ugat = ugat; // Felelősség injektálás
        }
        public void Ugat()
        {
            ugat.Ugat(); // Felelősség átadása
        }
    }

    // Gyerekosztály
    class Vizsla : Kutya
    {
        public Vizsla(IUgat ugat): base(ugat)
        {
            
        }
    }
}
