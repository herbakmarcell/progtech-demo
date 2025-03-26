using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025C
{
    // Alap osztályunk, amit később szeretnénk átalakítani
    class Robot
    {
        string? id = null;
        public string GetID()
        {
            return id;
        }
        public void SetID(string id)
        {
            this.id = id;
        }
    }

    // Alap abstract osztály (szemléltetés céljából)
    // Az adatainkat ebben a formában szeretnénk látni
    abstract class Human
    {
        public abstract void SpeakName();
    }

    // Az adapter örökli az átalakító osztály tulajdonságait.
    class Robot2HumanAdapter : Human
    {
        // Tárolt példány, aminek a példányának a mezőit és metódusait szeretnénk használni
        Robot createdHuman;

        // Adapter példányosításkor kell az átalakítandó példány referenciája
        public Robot2HumanAdapter(Robot robot)
        {
            this.createdHuman = robot;
        }

        // Az örökölt osztály metódusait felülírjuk, és alkalmazzuk benne az átalakítandó osztály metódusát
        // Ezek persze széles körűek lehetnek, property-re is lehetne alkalmazni
        public override void SpeakName()
        {
            Console.WriteLine("My name is: " + createdHuman.GetID());
        }
    }
}
