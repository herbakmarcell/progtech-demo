using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025C
{
    abstract class Doge // BaseClass
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
    }

    class Yorki : Doge // Class
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
    }

    abstract class DecoratorBase : Doge
    {
        Doge doge;

        public override string Name { get => doge.Name; set => doge.Name = value; }
        public override int Age { get => doge.Age; set => doge.Age = value; }

        protected DecoratorBase(Doge doge)
        {
            this.doge = doge;
        }
    }

    class Spotty : DecoratorBase
    {
        public bool IsSpotty { get; set; }
        public Spotty(Doge doge) : base(doge)
        {
            this.IsSpotty = true;
        }
    }

    class BlueEyes : DecoratorBase
    {
        public string Eyes { get; set; }

        public BlueEyes(Doge doge) : base(doge)
        {
            
        }
    }

}
