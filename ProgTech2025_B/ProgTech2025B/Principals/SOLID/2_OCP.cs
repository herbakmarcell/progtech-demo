using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Principals.SOLID
{
    // Open-Closed Principal - Nyitva-zárt alapelv
    // "Classes should be open for extension, but closed for modification"
    // "Legyen nyitott a bővítésre, de zárt a módosításra"

    // 1. a változás miatt az eddig működő ágak hibásak lehetnek
    // 2. a változás miatt a vele implementációs függőségben lévő kódrészeket is változtatni kell
    // 3. a változás általában azt jelenti, hogy olyan esetet kezelünk le, amit eddig nem, azaz bejön egy
    // új if vagy else, esetleg egy switch, ami csökkenti a kód átláthatóságát, egy idő után már senki se mer hozzányúlni

    // Legyen egy osztályunk az "Alakzat" osztály
    // Ebben szeretnénk, ha alakzattól függően rajzolná ki az alakzatot egy vászonra
    class Shape
    {
        // Megkérdezzük, hogy az alakzat egy kör-e? - már itt gyanúsan kell nézni a forráskódot
        bool isCircle;
        public Shape(bool isCircle) { this.isCircle = isCircle; }

        public void DrawShape()
        {
            // OCP megszegése
            // Miért is szegi meg az OCP-t?
            // 3. pontba foglalt - Mi van akkor, ha implementálni szeretnénk egy négyzet rajzolást?
            // Beírok egy új bool-t, aztán bővítem az if-et? Mi van ha még többet szeretnék? Lekezelem minden alakzatot if-else-el?
            // 2. pontba foglalt - A DrawShape függvény kimenetele FÜGG a logikai változók állapotától
            // A DrawShape nem lesz következetes, a programozó nehezen tudja kikövetkeztetni, hogy mi lesz az eredmény.
            // 1. pontba foglalt - Ha több alakzatot írok be logikai változóba, mit fog rajzolni?
            // Mivel az if szekvenciálisan fut le, ezért a leghamarabbi igaz ág fog működésbe lépni, ezért bár megadhatunk,
            // hogy rajzoljunk paralelogrammát, mégis a kód kört fog rajzolni, mert az van hamarabb az if-else ágak közül
            if (isCircle)
            {
                Console.WriteLine("Drawing Circle.");
            }
            else
            {
                Console.WriteLine("Drawing Geoid.");
            }
        }

        // 1. felelősségi kör
        public void DrawCircle() { Console.WriteLine("Drawing Circle."); }
        // 2. felelősség - SRP megszegése
        // Ez már csak hab a tortán, hogy SRP-t is megszegjük, persze ezen lehet vitatkozni, mi számít
        // itt egy felelősségi körnek - most a 2D-s vagy 3D-s objektumok vagy a négyszög és ötszög alapúak
        public void DrawGeoid() { Console.WriteLine("Drawing Geoid."); }
    }

    // Helyes megoldás
    abstract class AbstractShape
    {
        public abstract void DrawShape();
    }

    class Circle : AbstractShape
    {
        public Circle()
        {
        }

        public override void DrawShape()
        {
            Console.WriteLine("Drawing Circle."); ;
        }
    }

    class Geoid : AbstractShape
    {
        public Geoid() { }
        // 1. felelősség
        public override void DrawShape()
        {
            // 3. pontba foglalt - if eltűnt -> OCP megszegése eltűnt
            // 2. pontba foglalt - nincs logikai változó, csak az osztálytól függ, azaz nem szegi az OCP-t
            // 1. pontba foglalt - nincsennek alágak, így könnyebb javítani, és nem romlik el feltétlenül, ha felülírjuk
            Console.WriteLine("Drawing Geoid.");
        }
    }
}
