using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Patterns
{
    abstract class CreatedObject
    {
        public string Name { get; set; }
        public abstract string Description();

        protected CreatedObject(string name)
        {
            Name = name;
        }
    }

    class CreatedObjectA : CreatedObject
    {
        public CreatedObjectA(string name) : base(name)
        {
        }

        public override string Description()
        {
            string desc = "Object A name: " + Name;
            Console.WriteLine(desc);
            return desc;
        }
    }

    class CreatedObjectB : CreatedObject
    {
        public CreatedObjectB(string name) : base(name)
        {
        }
        public override string Description()
        {
            string desc = "Object B name: " + Name;
            Console.WriteLine(desc);
            return desc;
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
            return new CreatedObjectA(name);
        }
    }

    class FactoryB : FactoryBase
    {
        public override CreatedObject Create(string name)
        {
            return new CreatedObjectB(name);
        }
    }

}
