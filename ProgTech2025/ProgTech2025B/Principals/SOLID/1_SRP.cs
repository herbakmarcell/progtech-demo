using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Principals.SOLID
{
    // Single Responsibility Principal
    // Egy felelősség - egy osztály alapelve
    // "A class should have only one reason to change"
    // "Az osztályoknak csak egy oka legyen a változásra"
    // Másképpen megfogalmazva, az osztály egy felelősségi kört fedjen csak le
    class CatDog
    {
        // 1. felelősségi kör
        // A macskának az evését biztosítja.
        public void CatEating()
        {
            Console.WriteLine("The cat is eating...");
        }
        // 1. felelősségi kör
        // Nem feltétlen sérti az SRP-t, ez függ az osztály definíciótól
        // Itt most azt feltételezzük, hogy a "macska" funkciói a felelőségének a köre
        public void CatDrinking()
        {
            Console.WriteLine("The cat is drinking...");
        }
        // 2. felelősségi kör - SRP megszegése
        // A "kutya" funkciói már egy másik felelősségi kör
        public void DogEating()
        {
            Console.WriteLine("The doge is eating...");
        }
    }
    // SRP szerint - szedjük szét a felelősségi köröket
    interface IEat
    {
        void Eating();
    }

    interface IDrink
    {
        void Drinking();
    }
    // Macska felelősségi kör
    class Cat : IEat, IDrink
    {
        public void Eating()
        {
            Console.WriteLine("The cat is eating...");
        }
        public void Drinking()
        {
            Console.WriteLine("The cat is drinking...");
        }
    }
    // Kutya felelősségi kör
    class Dog : IEat
    {
        public void Eating()
        {
            Console.WriteLine("The doge is eating...");
        }
    }

    // Másik példa
    // SRP nélkül
    class DatabaseManagmentSystem
    {
        void CreateData() { }
        void DeleteData() { }
        // Több felelősségi kör
        void CreateDataWithExtraFields() { }
        void DestroyDatabase() { }
    }

    // SRP szerint
    class DatabaseManagement
    {
        void CreateData() { }
        void DeleteData() { }
    }

    class DatabaseInteraction
    {
        void CreateDataWithExtraFields() { }
        void DestroyDatabase() { }
    }
}
