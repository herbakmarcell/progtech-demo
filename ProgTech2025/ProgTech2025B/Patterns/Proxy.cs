using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025B.Patterns
{
    abstract class AbstractList
    {
        public abstract void AddStudent(string name);
        public abstract List<string> GetStudents();
    }

    class StudentList : AbstractList
    {
        public List<string> students;

        public StudentList()
        {
            students = new List<string>();
        }

        public override void AddStudent(string name)
        {
            students.Add(name);
        }

        public override List<string> GetStudents()
        {
            return students;
        }
    }

    class ProxyList : AbstractList
    {
        StudentList studentList;

        public ProxyList(StudentList sL)
        {
            if (sL == null)
            {
                studentList = new StudentList();
            }
            studentList = sL;
        }

        public override void AddStudent(string name)
        {
            Console.WriteLine($"Hozzáadjuk {name} tanulót.");
            studentList.AddStudent(name);
        }

        public override List<string> GetStudents()
        {
            Console.WriteLine("Visszaadom a tanulók listáját.");
            return studentList.GetStudents();
        }
    }

    //

    abstract class Factor
    {
        public abstract long Fact(long n);
    }

    class FactorCache : Factor
    {
        Dictionary<long, long> factorPairs;
        FactorMethod f;
        public FactorCache()
        {
            // Például fájból beolvasunk
            factorPairs = new Dictionary<long, long>();
            f = new FactorMethod();
        }

        public override long Fact(long n)
        {
            if (factorPairs.ContainsKey(n)) { return factorPairs[n]; }
            long value = f.Fact(n);
            factorPairs.Add(n, value);
            return value;
        }

        class FactorMethod : Factor
        {
            public override long Fact(long n)
            {
                if (n == 0) return 1;
                return n * Fact(n - 1);
            }
        }
    }
}
