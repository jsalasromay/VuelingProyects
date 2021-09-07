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
    }
}
