using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025C
{
    abstract class CreatedObject
    {
        public string Name { get; set; }
        public abstract void Description();

        protected CreatedObject(string name)
        {
            this.Name = name;
        }
    }

    class ObjectA : CreatedObject
    {
        public ObjectA(string name) : base(name) { }

        public override void Description()
        {
            Console.WriteLine(this.Name + "A");
        }
    }

    class ObjectB : CreatedObject
    {
        public ObjectB(string name) : base(name) { }

        public override void Description()
        {
            Console.WriteLine(this.Name + "B");
        }
    }

    abstract class FactoryBase
    {
        public abstract CreatedObject Create(string name);
    }

    class FactoryA : FactoryBase
    {
        public override CreatedObject Create(string name)
        {
            if (name == null) return null;
            Console.WriteLine("Generated 'A' object.");
            return new ObjectA(name);
        }
    }

    class FactoryB : FactoryBase
    {
        public override CreatedObject Create(string name)
        {
            Console.WriteLine("Generated 'B' object.");
            return new ObjectB(name);
        }
    }
}
