using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace Singleton
{
    class Program
    {

        public sealed class Adam : Male
        {
            private static Adam adam;
            private Adam()
            {

            }
            public static Adam GetInstance()
            {
                if (adam == null)
                {
                    adam = new Adam
                    {
                        Name = "Adam"
                    };
                }
                return adam;
            }

        }
        public sealed class Eve : Female
        {
            private static Eve eve;
            private Eve()
            {

            }
            public static Eve GetInstance(Adam adam)
            {
                if (adam != null && eve == null)
                {
                    eve = new Eve
                    {
                        Name = "Eve"
                    };
                }
                return eve;
            }

        }
        public class Seth : Male { }
        public class Azura : Male { }
        public class Enos : Male { }
        public class Male : Human 
        {
            public Male(string NameS, Female MotherS, Male FatherS)
            {
                Name = NameS;
                if (MotherS == null && FatherS == null)
                {
                    throw new ArgumentNullException();
                }
                Mother = MotherS;
                Father = FatherS;
            }
            protected Male()
            {

            }
        }
        public class Female : Human
        {
            public Female(string NameS, Female MotherS, Male FatherS)
            {
                Name = NameS;
                if (MotherS == null && FatherS == null)
                {
                    throw new ArgumentNullException();
                }
                Mother = MotherS;
                Father = FatherS;

            }
            protected Female()
            {

            }
        }
        public abstract class Human
        {
            public string Name;
            public Female Mother;
            public Male Father;
        }

        public static class SampleTests
        {
            public static void Adam_is_unique()
            {
                Adam adam = Adam.GetInstance();
                Adam anotherAdam = Adam.GetInstance();

                Assert.IsTrue(adam is Adam);
                Assert.AreEqual(adam, anotherAdam);
            }
            public static void Adam_is_unique_and_only_GetInstance_can_return_adam()
            {
                // GetInstance() is the only static method on Adam
                Assert.AreEqual(1, typeof(Adam).GetMethods().Where(x => x.IsStatic).Count());

                // Adam does not have public or internal constructors
                Assert.IsFalse(typeof(Adam).GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                  .Any(x => x.IsPublic || x.IsAssembly));
            }
            public static void Adam_is_unique_and_cannot_be_overriden()
            {
                Assert.IsTrue(typeof(Adam).IsSealed);
            }
            public static void Adam_is_a_human()
            {
                Assert.IsTrue(Adam.GetInstance() is Human);
            }
            public static void Adam_is_a_male()
            {
                Assert.IsTrue(Adam.GetInstance() is Male);
            }
            public static void Eve_is_unique_and_created_from_a_rib_of_adam()
            {
                Adam adam = Adam.GetInstance();
                Eve eve = Eve.GetInstance(adam);
                Eve anotherEve = Eve.GetInstance(adam);

                Assert.IsTrue(eve is Eve);
                Assert.AreEqual(eve, anotherEve);

                // GetInstance() is the only static method on Eve
                Assert.AreEqual(1, typeof(Eve).GetMethods().Where(x => x.IsStatic).Count());

                // Eve has no public or internal constructor
                Assert.IsFalse(typeof(Eve).GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                  .Any(x => x.IsPublic || x.IsAssembly));

                // Eve cannot be overridden
                Assert.IsTrue(typeof(Eve).IsSealed);
            }
            public static void Eve_can_only_be_create_of_a_rib_of_adam()
            {
                try
                {
                    Eve.GetInstance(null);
                    Assert.Fail();
                }
                catch (ArgumentNullException ex)
                {
                    Assert.IsTrue(true);
                }
            }
            public static void Eve_is_a_human()
            {
                Assert.IsTrue(Eve.GetInstance(Adam.GetInstance()) is Human);
            }
            public static void Eve_is_a_female()
            {
                Assert.IsTrue(Eve.GetInstance(Adam.GetInstance()) is Female);
            }
            public static void Reproduction_always_result_in_a_male_or_female()
            {
                Assert.IsTrue(typeof(Human).IsAbstract);
            }
            public static void Humans_can_reproduce_when_there_is_a_name_a_mother_and_a_father()
            {
                var adam = Adam.GetInstance();
                var eve = Eve.GetInstance(adam);
                var seth = new Male("Seth", eve, adam);
                var azura = new Female("Azura", eve, adam);
                var enos = new Male("Enos", azura, seth);

                Assert.AreEqual("Eve", eve.Name);
                Assert.AreEqual("Adam", adam.Name);
                Assert.AreEqual("Seth", seth.Name);
                Assert.AreEqual("Azura", azura.Name);
                Assert.AreEqual("Enos", ((Human)enos).Name);
                Assert.AreEqual(seth, ((Human)enos).Father);
                Assert.AreEqual(azura, ((Human)enos).Mother);
            }
            public static void Father_and_mother_are_essential_for_reproduction()
            {
                // There is just 1 way to reproduce 
                Assert.AreEqual(1, typeof(Male).GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                  .Where(x => x.IsPublic || x.IsAssembly).Count());
                Assert.AreEqual(1, typeof(Female).GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).
                  Where(x => x.IsPublic || x.IsAssembly).Count());

                var adam = Adam.GetInstance();
                var eve = Eve.GetInstance(adam);
                Assert.Throws<ArgumentNullException>(() => new Male("Seth", null, null));
                Assert.Throws<ArgumentNullException>(() => new Male("Abel", eve, null));
                Assert.Throws<ArgumentNullException>(() => new Male("Seth", null, adam));
                Assert.Throws<ArgumentNullException>(() => new Female("Azura", null, null));
                Assert.Throws<ArgumentNullException>(() => new Female("Awan", eve, null));
                Assert.Throws<ArgumentNullException>(() => new Female("Dina", null, adam));
                Assert.Throws<ArgumentNullException>(() => new Female("Eve", null, null));
                Assert.Throws<ArgumentNullException>(() => new Male("Adam", null, null));
            }

        }
        static void Main(string[] args)
        {
            SampleTests.Adam_is_unique();
            Console.WriteLine("(TEST) Adam is unique");
            SampleTests.Adam_is_unique_and_only_GetInstance_can_return_adam();
            Console.WriteLine("(TEST) Adam is unique and getInstance can return adam");
            SampleTests.Adam_is_unique_and_cannot_be_overriden();
            Console.WriteLine("(TEST) Adam cannot be overriden");
            SampleTests.Adam_is_a_human();
            Console.WriteLine("(TEST) Adam is a human");
            SampleTests.Adam_is_a_male();
            Console.WriteLine("(TEST) Adam is a male");
            SampleTests.Eve_is_unique_and_created_from_a_rib_of_adam();
            Console.WriteLine("(TEST) Eve is unique and created from a rib of adam");
            //SampleTests.Eve_can_only_be_create_of_a_rib_of_adam();
            //Console.WriteLine("(TEST) Eve can only be create of a rib of adam");
            SampleTests.Eve_is_a_human();
            Console.WriteLine("(TEST) Eve is a human");
            SampleTests.Eve_is_a_female();
            Console.WriteLine("(TEST) Eve is a female");
            SampleTests.Reproduction_always_result_in_a_male_or_female();
            Console.WriteLine("(TEST) Reproduction always result in a male or female");
            SampleTests.Humans_can_reproduce_when_there_is_a_name_a_mother_and_a_father();
            Console.WriteLine("(TEST) Humans can reproduce with a mother and a father");
            SampleTests.Father_and_mother_are_essential_for_reproduction();
            Console.WriteLine("(TEST) Mother and Father are essential for reproduction");
        }
    }
}
