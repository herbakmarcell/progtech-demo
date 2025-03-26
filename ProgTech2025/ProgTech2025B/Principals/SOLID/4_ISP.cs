using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Principals.SOLID
{
    interface IBark
    {
        void Bark();
    }

    interface EatI
    {
        void Eat();
    }

    interface IDog : IBark, EatI { }

    class DogISP : IDog
    {
        public void Bark()
        {
            Console.WriteLine("Bark");
        }

        public void Eat()
        {
            Console.WriteLine("Eat");
        }
    }
}
