using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Principals
{
    class A
    {
        int value = 7;
        public int GetValue() { return value; }
    }

    class B
    {
        public A a = new A();

        int GetAValue() { return a.GetValue(); }
        public int GetBValue() { return GetAValue(); }
    }

    class C
    {
        public B b = new B();

        int GetBValue() { return b.GetBValue(); }
        public int GetCValue() { return GetBValue(); }
    }

    class D
    {
        C c = new C();

        int GetCValue() { return c.GetCValue(); }
        public int GetAValue() { return GetCValue(); }
    }
}
