using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025C
{
    class MacsKuty
    {
        public void MacskaEvés() 
        {
            Console.WriteLine("A macska eszik.");
        }
        public void KutyaEvés()
        {
            Console.WriteLine("A kutya eszik.");
        }
    }

    // Megoldás

    interface IEvés
    {
        void Evés();
    }

    abstract class Állat : IEvés
    {
        public abstract void Evés();
    }

    class Macska : Állat
    {
        public override void Evés()
        {
            Console.WriteLine("A macska eszik.");
        }
    }

    class Kuttya : Állat
    {
        public override void Evés()
        {
            Console.WriteLine("A kuttya eszik.");
        }
    }
}
