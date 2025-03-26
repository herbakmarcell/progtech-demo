namespace ProgTech2025C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stratégia
            Kutya vizsla1 = new Vizsla(new VizslaUgatásStratégia());

            vizsla1.Ugat(); // Késői kötés miatt a gyermekosztálybeli metódus fut le

            // Adapter
            Robot robot = new Robot();
            robot.SetID("Robi");

            Human robiHuman = new Robot2HumanAdapter(robot);
            robiHuman.SpeakName();

            // Factory Method

            //FactoryBase[] factories = new FactoryBase[2];
            FactoryBase fA = new FactoryA();
            FactoryBase fB = new FactoryB();

            List<CreatedObject> createdObjects = new List<CreatedObject>();

            for (int i = 0; i < 5; i++)
            {
                createdObjects.Add(fA.Create(i.ToString()));
                createdObjects.Add(fB.Create(i.ToString()));
            }

            createdObjects[0].Description();

            // Decorator

            Doge myYorki = new Yorki();
            myYorki.Name = "New Yorki";
            myYorki.Age = 4;
            Spotty spottyYorki = new Spotty(myYorki);
            BlueEyes blueEyesSpottyYorki = new BlueEyes(spottyYorki);

            // teleszkópikus
            Doge myNewYorki = new BlueEyes(new Spotty(new Yorki() 
            { Name = "New New Yorki", Age = 0})); 
            Console.WriteLine(blueEyesSpottyYorki.Name);

            // SRP
            Állat macsek = new Macska();
            macsek.Evés();


            Console.ReadKey();
        }
    }
}
