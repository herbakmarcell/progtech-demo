using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Principals.SOLID
{
    abstract class Plant
    {
        protected int leafCount;

        protected Plant()
        {
            //Random rnd = new Random();
            //leafCount = rnd.Next(0, 420);
            leafCount = 100;
        }
        public abstract int LeafCount();
    }


    class Tree : Plant // o2 objektumunk
    {
        public override int LeafCount()
        {
            return leafCount;
        }
    }

    class Scrub : Plant // o1 objektumunk
    {
        public override int LeafCount()
        {
            return leafCount;
        }
    }
}
