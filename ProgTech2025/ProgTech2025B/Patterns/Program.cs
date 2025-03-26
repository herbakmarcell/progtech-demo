using ProgTech2025B.Principals.SOLID;
using System.Diagnostics;

namespace ProgTech2025B.Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stratégia

            Katscha donaldKatscha = new Katscha(new DonaldHápogás());
            donaldKatscha.Hápog(); // Ha a Katscha osztály abstract volna, és lenne egy gyerekosztálya
                                   // akkor késői kötés miatt a gyermekosztálybeli metódus futna le
                                   //--------------------------------------------------------
                                   // Adapter

            Robot t1000 = new Robot();
            t1000.SetID("T999+1");
            Human arnold = new Robot2HumanAdapter(t1000); // Adapter példány
            arnold.SpeakName();
            //--------------------------------------------------------
            // Factory Method

            FactoryBase factoryA = new FactoryA();
            FactoryBase factoryB = new FactoryB();
            List<CreatedObject> createdObjects = new List<CreatedObject>();
            for (int i = 0; i < 10; i++)
            {
                // ehelyett
                //createdObjects.Add(new CreatedObjectA(i.ToString() + "A"));
                // ezt
                createdObjects.Add(factoryA.Create(i.ToString() + "A"));

                createdObjects.Add(factoryB.Create(i.ToString() + "B"));
            }

            createdObjects[0].Description();
            //--------------------------------------------------------
            // Decorator

            SuzukiSwift suzuki = new SuzukiSwift(2010);
            SpecialOffer special = new SpecialOffer(suzuki);
            Hireable h = new Hireable(special);

            // Teleszkóposan
            VehicleBase v = new Hireable(new SpecialOffer(new SuzukiSwift(2010)));

            //--------------------------------------------------------

            // LSP
            Plant scrub1 = new Tree();

            Console.WriteLine(scrub1.LeafCount());

            // ISP
            IBark dog1 = new DogISP();
            EatI dog2 = new DogISP();
            IDog dog3 = new DogISP();

            dog1.Bark();

            dog2.Eat();

            dog3.Bark();
            dog3.Eat();

            // Proxy

            AbstractList studentList = new StudentList();
            AbstractList proxyStudentList = new ProxyList(studentList as StudentList);

            studentList.AddStudent("Kis Endre Farkas");
            Console.WriteLine("Valódi 0. eleme: " + studentList.GetStudents()[0]);
            Console.WriteLine("Proxy 0. eleme: " + proxyStudentList.GetStudents()[0]);

            Factor factorCalc = new FactorCache();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(factorCalc.Fact(44));
            sw.Stop();

            Console.WriteLine("Első próba ideje: " + sw.ElapsedMilliseconds);
            sw.Reset();

            sw.Start();
            Console.WriteLine(factorCalc.Fact(44));
            sw.Stop();
            Console.WriteLine("Második próba ideje: " + sw.ElapsedMilliseconds);


            Console.ReadKey();
        }
    }
}
