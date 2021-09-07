using NUnit.Framework;
using Singleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Singleton.Tests
{
    class TestService
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
            Eve.GetInstance(null);
            Console.WriteLine($"Eve needs Adam");
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
            try
            {
                var seth = new Male("Seth", null, null);
            }
            catch (ArgumentNullException) { }
            try
            {
                var abel = new Male("Abel", eve, null);
            }
            catch (ArgumentNullException) { }
            try
            {
                var seth = new Male("Seth", null, adam);
            }
            catch (ArgumentNullException) { }
            try
            {
                var azura = new Female("Azura", null, null);
            }
            catch (ArgumentNullException) { }
            try
            {
                var awan = new Female("Awan", eve, null);
            }
            catch (ArgumentNullException) { }
            try
            {
                var dina = new Female("Dina", null, adam);
            }
            catch (ArgumentNullException) { }
            try
            {
                var eve2 = new Female("Eve", null, null);
            }
            catch (ArgumentNullException) { }
            try
            {
                var adam2 = new Male("Adam", null, null);
            }
            catch (ArgumentNullException) { }
        }
    }
}
