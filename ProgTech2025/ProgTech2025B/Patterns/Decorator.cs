using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Patterns
{
    // Alap absztrakt osztály
    // A ez fogja képezni a dekorálandó és dekoráló osztályok alapját
    abstract class VehicleBase
    {
        public abstract string Name { get; set; }
        public abstract string Model { get; set; }
    }
    // Dekorálandó osztály
    class SuzukiSwift : VehicleBase
    {
        public override string Name { get; set; }
        public override string Model { get; set; }
        public int Year { get; set; }

        public SuzukiSwift(int year, string name = "Suzuki", string model = "Swift")
        {
            Name = name;
            Model = model;
            Year = year;
        }

    }
    // Dekoráló osztály alapja
    abstract class DecoratorBase : VehicleBase // IS-A kapcsolat - átlátszó becsomagolás tulajdonsága
    {
        // Tartalmaz egy alap osztály objektumot, később ebben tároljuk el
        // a dekorálandó osztály objektumunkat
        VehicleBase v; // Objektum-összetétel - HAS-A kapcsolat

        public DecoratorBase(VehicleBase v)
        {
            this.v = v;
        }

        // Felelősségek átadása
        // Mivel a dekorátor felülete megegyezik a dekorálandó osztály felületével (mezők és kódjuk ugyanaz)
        // ezért ez ÁTLÁTSZÓ becsomagolás
        public override string Name { get => v.Name; set => v.Name = value; }
        public override string Model { get => v.Model; set => v.Model = value; }

        // Amennyiben a felület nem egyezne meg, vagy nem lenne IS-A kapcsolat, akkor ÁTLÁTSZATLAN becsomagolás lenne
    }

    // Konkrét dekorátor
    class SpecialOffer : DecoratorBase
    {
        public SpecialOffer(VehicleBase v) : base(v)
        {
        }
    }

    // Konkrét dekorátor
    class Hireable : DecoratorBase
    {
        public Hireable(VehicleBase v) : base(v)
        {
        }
    }
}

