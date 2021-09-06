using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Singleton.Tests;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TestService.Adam_is_unique();
            Console.WriteLine($"Test Adam is unique OK");
            TestService.Adam_is_unique_and_only_GetInstance_can_return_adam();
            Console.WriteLine($"Test Adam is unique and only GetInstance can return adam OK");
        }
    }
}
